using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace SFE
{
    public partial class consommationForm : Form
    {
        public consommationForm()
        {
            InitializeComponent();
        }

        private void consommationForm_Load(object sender, EventArgs e)
        {
            dateTimePickerDateOperation.Value = DateTime.Now;

            if (Clients.AdherentId != null)
            {
                Nbrpolice nbrpolice = new Nbrpolice(Clients.AdherentId, Clients.adherentNbrPolice);
                comboBoxNbrPolice.SelectedItem = nbrpolice;
            }

            try
            {
                DataAccess db = new DataAccess();

                SqlDataReader dr = db.getNbrpolicelist();
                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        comboBoxNbrPolice.Items.Add( new Nbrpolice(dr[0].ToString(), dr[1].ToString()));
                    }

                    comboBoxNbrPolice.ValueMember = "adherentId";
                    comboBoxNbrPolice.DisplayMember = "nbrPolice";
                }

                db.closeConnection();

                SqlDataReader dr2 = db.getPeriodeConsommationList();
                if (dr2.HasRows == true)
                {
                    while (dr2.Read())
                    {
                        comboBoxPeriodeConsommation.Items.Add(new PeriodeConsommation(dr2[0].ToString(), dr2[1].ToString()));
                    }

                    comboBoxPeriodeConsommation.ValueMember = "id_mois";
                    comboBoxPeriodeConsommation.DisplayMember = "mois";
                }

                db.closeConnection();
            }
            catch (Exception)
            {
                functions.errorMsgBox();
            }
        }

        private string clientId;
        private void comboBoxNbrPolice_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxCnturAvant.Text = "";
            textBoxCnturApres.Text = "";
            textBoxQnttConsommee.Text = "";
            textBoxPrixTotal.Text = "";
            textBoxMontantAPayer.Text = "";

            try
            {
                DataAccess db = new DataAccess();

                Nbrpolice nbrpolice = (Nbrpolice)comboBoxNbrPolice.SelectedItem;
                string id = nbrpolice.id;
                clientId = nbrpolice.id;

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

                SqlDataReader dr2 = db.loadCnturAvant(id);
                if (dr2.HasRows == true)
                {
                    while (dr2.Read())
                    {
                        textBoxCnturAvant.Text = dr2[0].ToString();
                    }
                }

                db.closeConnection();
            }
            catch (Exception)
            {
                functions.errorMsgBox();
            }
        }

        private void textBoxCnturApres_TextChanged(object sender, EventArgs e)
        {
            string cnturAvant = textBoxCnturAvant.Text;
            string cnturApres = textBoxCnturApres.Text;

            textBoxQnttConsommee.Text = loadQnttConsommee(cnturApres, cnturAvant);

            textBoxTonPrix_TextChanged(sender, e);
            textBoxTaxe_TextChanged(sender, e);
        }

        private void textBoxCnturAvant_TextChanged(object sender, EventArgs e)
        {
            string cnturAvant = textBoxCnturAvant.Text;
            string cnturApres = textBoxCnturApres.Text;

            textBoxQnttConsommee.Text = loadQnttConsommee(cnturApres, cnturAvant);

            textBoxTonPrix_TextChanged(sender, e);
            textBoxTaxe_TextChanged(sender, e);
        }

        private void textBoxTonPrix_TextChanged(object sender, EventArgs e)
        {
            string tonPrix = textBoxTonPrix.Text;
            string qnttConsommee = textBoxQnttConsommee.Text;

            textBoxPrixTotal.Text = loadPrixTotal(tonPrix, qnttConsommee);

            textBoxTaxe_TextChanged(sender, e);
        }

        private void textBoxTaxe_TextChanged(object sender, EventArgs e)
        {
            string prixTotal = textBoxPrixTotal.Text;
            string taxe = textBoxTaxe.Text;

            textBoxMontantAPayer.Text = loadMontantAPayer(prixTotal, taxe);
        }

        private string loadQnttConsommee(string apres, string avant)
        {
            float cnturApres;
            float.TryParse(apres, out cnturApres);

            float cnturAvant;
            float.TryParse(avant, out cnturAvant);

            float qnttConsommee = cnturApres - cnturAvant;

            return qnttConsommee.ToString();
        }

        private string loadPrixTotal(string tonPrixIns, string qnttConsommeeIns)
        {
            float tonPrix;
            float.TryParse(tonPrixIns, out tonPrix);

            float qnttConsommee;
            float.TryParse(qnttConsommeeIns, out qnttConsommee);

            float prixTotal;

            prixTotal = qnttConsommee * tonPrix;

            return prixTotal.ToString();
        }

        private string loadMontantAPayer(string prixTotalIns, string taxeIns)
        {
            float prixtotal;
            float.TryParse(prixTotalIns, out prixtotal);

            float taxe;
            float.TryParse(taxeIns, out taxe);

            float montantAPayer;

            montantAPayer = prixtotal + taxe;

            return montantAPayer.ToString();
        }

        private string id_mois;
        private string mois;
        private void comboBoxPeriodeConsommation_SelectedIndexChanged(object sender, EventArgs e)
        {
            PeriodeConsommation periode = (PeriodeConsommation)comboBoxPeriodeConsommation.SelectedItem;
            id_mois = periode.idMois;
            mois = periode.mois;
        }

        private string periodeInArabic;

        private void clearFields()
        {
            //comboBoxNbrPolice.SelectedItem = "" //null;
            textBoxCnturAvant.Text = "";
            textBoxCnturApres.Text = "";
            textBoxQnttConsommee.Text = "";
            textBoxTonPrix.Text = "";
            textBoxPrixTotal.Text = "";
            textBoxTaxe.Text = "";
            textBoxMontantAPayer.Text = "";
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
            if (comboBoxNbrPolice.Text != string.Empty && comboBoxPeriodeConsommation.Text != string.Empty && textBoxCnturApres.Text != string.Empty && textBoxTonPrix.Text != string.Empty && textBoxTaxe.Text != string.Empty)
            {
                float checkQntt;
                float.TryParse(loadQnttConsommee(textBoxCnturApres.Text, textBoxCnturAvant.Text), out checkQntt);
                if (checkQntt < 0) return;

                try
                {
                    string id = clientId;
                    string date = dateTimePickerDateOperation.Text;
                    string periode = id_mois;
                    string cnturAvant = textBoxCnturAvant.Text;
                    string cnturApres = textBoxCnturApres.Text;
                    string tonPrix = textBoxTonPrix.Text;
                    string taxe = textBoxTaxe.Text;

                    DataAccess db = new DataAccess();

                    db.insertConsommation(id, date, periode, cnturAvant, cnturApres, tonPrix, taxe);
                    db.closeConnection();

                    SqlDataReader dr = db.getNbrQuittance();
                    if (dr.HasRows == true)
                    {
                        while (dr.Read())
                        {
                            textBoxNbrQuittance.Text = dr[0].ToString();
                        }
                    }
                    db.closeConnection();

                    switch (mois)
                    {
                        case "Trimester 1":
                            periodeInArabic = "الشطر 1";
                            break;

                        case "Trimester 2":
                            periodeInArabic = "الشطر 2";
                            break;

                        case "Trimester 3":
                            periodeInArabic = "الشطر 3";
                            break;

                        case "Trimester 4":
                            periodeInArabic = "الشطر 4";
                            break;

                        default:
                            break;
                    }

                    PrintConsommation pcons = new PrintConsommation();

                    pcons.nbrFacture = textBoxNbrQuittance.Text;
                    pcons.nbrPolice = comboBoxNbrPolice.Text;
                    pcons.nom = textBoxNom.Text;
                    pcons.prenom = textBoxPrenom.Text;
                    pcons.dateOperation = date;
                    pcons.periode = periodeInArabic;
                    pcons.cnturAvant = cnturAvant;
                    pcons.cnturApres = cnturApres;
                    pcons.QnttConsommee = textBoxQnttConsommee.Text;
                    pcons.tonPrix = tonPrix;
                    pcons.prixTotal = textBoxPrixTotal.Text;
                    pcons.taxe = taxe;
                    pcons.montantAPayer = textBoxMontantAPayer.Text;
                    pcons.ShowDialog();

                    clearFields();

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
