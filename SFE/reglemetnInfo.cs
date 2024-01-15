using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SFE
{
    public partial class reglemetnInfo : Form
    {
        public reglemetnInfo()
        {
            InitializeComponent();

            loadClientName();
        }

        private void reglementInfo_Load(object sender, EventArgs e)
        {
            try
            {
                DataAccess db = new DataAccess();

                SqlDataReader dr = db.getReglementInfo(ReglementList.reglementId);
                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        textBoxRecu.Text = dr[2].ToString();
                        textBoxDateOperation.Text = dr[3].ToString();
                        textBoxMontant.Text = dr[4].ToString();
                        textBoxModePaiement.Text = dr[5].ToString();
                        textBoxObservation.Text = dr[6].ToString();
                        textBoxNbrRecu.Text = dr[7].ToString();
                    }
                }

                db.closeConnection();

                SqlDataReader dr2 = db.getClientNbrPolice(Clients.AdherentId);
                if (dr2.HasRows == true)
                {
                    while (dr2.Read())
                    {
                        textBoxNbrPolice.Text = dr2[0].ToString();
                    }
                }

                db.closeConnection();
            }
            catch (Exception)
            {
                functions.errorMsgBox();
            }
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            ConsRegSitBar.openChildFormConsRegSit(new ReglementList());
        }

        private string nom;
        private string prenom;

        private void loadClientName()
        {
            DataAccess db = new DataAccess();

            SqlDataReader dr = db.loadClientNomPrenom(Clients.AdherentId);
            if (dr.HasRows == true)
            {
                while (dr.Read())
                {
                    nom = dr[0].ToString();
                    prenom = dr[1].ToString();

                    textBoxNom.Text = dr[0].ToString() + " " + dr[1].ToString();
                }
            }

            db.closeConnection();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            PrintReglement preg = new PrintReglement();

            preg.nbrPolice = textBoxNbrPolice.Text;
            preg.nbrRecu = textBoxRecu.Text;
            preg.nom = nom;
            preg.prenom = prenom;
            preg.dateOperation = textBoxDateOperation.Text;
            preg.montant = textBoxMontant.Text;
            preg.modePaiement = textBoxModePaiement.Text;
            preg.recu = textBoxRecu.Text;
            preg.observation = textBoxObservation.Text;
            preg.ShowDialog();

        }
    }
}
