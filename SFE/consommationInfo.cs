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
    public partial class consommationInfo : Form
    {
        public consommationInfo()
        {
            InitializeComponent();

            loadClientName();
        }

        private void consommationInfo_Load(object sender, EventArgs e)
        {
            try
            {
                DataAccess db = new DataAccess();

                SqlDataReader dr = db.getConsommationInfo(ConsommationList.consommationId);
                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        textBoxNbrQuittance.Text = dr[2].ToString();
                        textBoxDateOperation.Text = dr[3].ToString();
                        textBoxPeriodeConsommation.Text = dr[11].ToString();
                        textBoxCnturAvant.Text = dr[4].ToString();
                        textBoxCnturApres.Text = dr[5].ToString();
                        textBoxQnttConsommee.Text = dr[6].ToString();
                        textBoxTonPrix.Text = dr[7].ToString();
                        textBoxTotalPrix.Text = dr[8].ToString();
                        textBoxTaxe.Text = dr[9].ToString();
                        textBoxMontantAPayer.Text = dr[10].ToString();
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
            ConsRegSitBar.openChildFormConsRegSit(new ConsommationList());
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
            PrintConsommation pcons = new PrintConsommation();

            pcons.nbrFacture = textBoxNbrQuittance.Text;
            pcons.nbrPolice = textBoxNbrPolice.Text;
            pcons.nom = nom;
            pcons.prenom = prenom;
            pcons.dateOperation = textBoxDateOperation.Text;
            pcons.periode = textBoxPeriodeConsommation.Text;
            pcons.cnturAvant = textBoxCnturAvant.Text;
            pcons.cnturApres = textBoxCnturApres.Text;
            pcons.QnttConsommee = textBoxQnttConsommee.Text;
            pcons.tonPrix = textBoxTonPrix.Text;
            pcons.prixTotal = textBoxTotalPrix.Text;
            pcons.taxe = textBoxTaxe.Text;
            pcons.montantAPayer = textBoxMontantAPayer.Text;
            pcons.ShowDialog();
        }
    }
}
