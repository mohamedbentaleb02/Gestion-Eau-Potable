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
    public partial class clientInfoForm : Form
    {
        public clientInfoForm()
        {
            InitializeComponent();
        }

        private void clientInfoForm_Load(object sender, EventArgs e)
        {
            try
            {
                DataAccess db = new DataAccess();

                SqlDataReader dr = db.loadClientInfo(Clients.AdherentId);
                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        textBoxNom.Text = dr[1].ToString();
                        textBoxPrenom.Text = dr[2].ToString();
                        textBoxCIN.Text = dr[3].ToString();
                        textBoxNbrPolice.Text = dr[4].ToString();
                        textBoxPhone.Text = dr[5].ToString();
                    }
                }

                db.closeConnection();
            }
            catch (Exception)
            {
                functions.errorMsgBox();
            }
        }

        private void buttonAppliquer_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNom.Text != string.Empty && textBoxPrenom.Text != string.Empty && textBoxCIN.Text != string.Empty && textBoxNbrPolice.Text != string.Empty)
                {
                    DataAccess db = new DataAccess();

                    string id = Clients.AdherentId;
                    string nom = textBoxNom.Text;
                    string prenom = textBoxPrenom.Text;
                    string cin = textBoxCIN.Text;
                    string nbrPolice = textBoxNbrPolice.Text;
                    string phone = textBoxPhone.Text;

                    try
                    {
                        db.updateAdherent(id, nom, prenom, cin, nbrPolice, phone);
                        db.closeConnection();

                        defaultForm.openChildForm(new Clients());
                    }
                    catch (Exception)
                    {
                        functions.errorMsgBox();
                    }
                }
            }
            catch (Exception)
            {
                functions.errorMsgBox();
            }
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            defaultForm.openChildForm(new Clients());
        }
    }
}
