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
    public partial class reglementForm : Form
    {
        public reglementForm()
        {
            InitializeComponent();
        }

        private void reglementForm_Load(object sender, EventArgs e)
        {
            dateTimePickerDateOperation.Value = DateTime.Now;

            labelNbrRecu.Visible = false;
            textBoxNbrRecu.Visible = false;

            labelReste.Visible = false;
            textBoxReste.Visible = false;

            try
            {
                DataAccess db = new DataAccess();

                SqlDataReader dr = db.getNbrpolicelist();
                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        comboBoxNbrPolice.Items.Add(new Nbrpolice(dr[0].ToString(), dr[1].ToString()));
                    }

                    comboBoxNbrPolice.ValueMember = "adherentId";
                    comboBoxNbrPolice.DisplayMember = "nbrPolice";
                }

                db.closeConnection();
            }
            catch (Exception)
            {
                functions.errorMsgBox();
            }
        }

        private string clientId;
        private string nbrPoliceselected;
        private void comboBoxNbrPolice_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (labelReste.Visible == false && textBoxReste.Visible == false)
                {
                    labelReste.Visible = true;
                    textBoxReste.Visible = true;
                }

                DataAccess db = new DataAccess();

                Nbrpolice nbrpolice = (Nbrpolice)comboBoxNbrPolice.SelectedItem;
                string id = nbrpolice.id;
                clientId = nbrpolice.id;
                nbrPoliceselected = nbrpolice.nbrPolice;

                SqlDataReader dr = db.loadClientNomPrenom(id);
                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        textBoxNom.Text = dr[0].ToString();
                        textBoxPrenom.Text = dr[1].ToString();
                    }
                }
                db.closeConnection();

                SqlDataReader dr2 = db.loadClientReste(id);
                if (dr2.HasRows == true)
                {
                    while (dr2.Read())
                    {
                        textBoxReste.Text = dr2[0].ToString();
                    }
                }
                db.closeConnection();
            }
            catch (Exception)
            {
                functions.errorMsgBox();
            }
        }

        private string modeInArabic;

        private void clearFields()
        {
            textBoxMontant.Text = "";
            textBoxNbrRecu.Text = "";
            textBoxObservation.Text = "";
            textBoxReste.Text = "";
        }

        private void comboBoxModePaiement_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxModePaiement.Text == "Cheque" || comboBoxModePaiement.Text == "Carte")
            {
                if (labelNbrRecu.Visible == false && textBoxNbrRecu.Visible == false)
                {
                    labelNbrRecu.Visible = true;
                    textBoxNbrRecu.Visible = true;
                }
            }
            else if (comboBoxModePaiement.Text == "Espèce")
            {
                if (labelNbrRecu.Visible == true && textBoxNbrRecu.Visible == true)
                {
                    labelNbrRecu.Visible = false;
                    textBoxNbrRecu.Visible = false;
                }    
            }
        }

        private void dateTimePickerDateOperation_ValueChanged(object sender, EventArgs e)
        {
            //var newDate = (dateTimePickerDateOperation.Value - DateTime.Now).Days;
            var newDate = dateTimePickerDateOperation.Value;

            /*if (newDate > 0 || newDate < -1)
            {
                dateTimePickerDateOperation.Value = DateTime.Now;
            }*/
        }

        private void buttonAppliquer_Click(object sender, EventArgs e)
        {
            if (comboBoxNbrPolice.Text != string.Empty && textBoxMontant.Text != string.Empty && comboBoxModePaiement.Text != string.Empty)
            {
                if (textBoxNbrRecu.Visible == true && textBoxNbrRecu.Text == string.Empty) return;

                try
                {
                    string id = clientId;
                    string date = dateTimePickerDateOperation.Text;
                    string montant = textBoxMontant.Text;
                    string paiMode = comboBoxModePaiement.Text;
                    string recu = textBoxNbrRecu.Text;
                    string observation = textBoxObservation.Text;

                    DataAccess db = new DataAccess();

                    db.insertReglement(id, date, montant, paiMode, observation, recu);
                    db.closeConnection();

                    SqlDataReader dr = db.getNbrRecu();
                    if (dr.HasRows == true)
                    {
                        while (dr.Read())
                        {
                            textBoxRecu.Text = dr[0].ToString();
                        }
                    }
                    db.closeConnection();

                    switch (paiMode)
                    {
                        case "Carte":
                            modeInArabic = "بطاقة بنكية";
                            break;

                        case "Cheque":
                            modeInArabic = "شيك";
                            break;

                        case "Espèce":
                            modeInArabic = "نقدا";
                            break;

                        default:
                            break;
                    }

                    PrintReglement preg = new PrintReglement();

                    preg.nbrPolice = nbrPoliceselected;
                    preg.nbrRecu = textBoxRecu.Text;
                    preg.nom = textBoxNom.Text;
                    preg.prenom = textBoxPrenom.Text;
                    preg.dateOperation = date;
                    preg.montant = montant;
                    preg.modePaiement = modeInArabic;
                    preg.recu = recu;
                    preg.observation = observation;
                    preg.ShowDialog();

                    clearFields();

                    labelReste.Visible = false;
                    textBoxReste.Visible = false;
                }
                catch (Exception)
                {
                    functions.errorMsgBox();
                }
            }
        }

        private void buttonAnnuler_Click_1(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
