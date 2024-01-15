using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SFE
{
    public partial class addClientForm : Form
    {
        public addClientForm()
        {
            InitializeComponent();
            //buttonAppliquer.KeyPress += new KeyPressEventHandler(keypressed);

            //KeyPreview = true;
        }

        private void clearFields()
        {
            textBoxNom.Text = "";
            textBoxPrenom.Text = "";
            textBoxCIN.Text = "";
            textBoxNbrPolice.Text = "";
            textBoxPhone.Text = "";
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNom.Text != string.Empty && textBoxPrenom.Text != string.Empty && textBoxCIN.Text != string.Empty && textBoxNbrPolice.Text != string.Empty)
                {
                    DataAccess db = new DataAccess();

                    string nom = textBoxNom.Text;
                    string prenom = textBoxPrenom.Text;
                    string cin = textBoxCIN.Text;
                    string nbrPolice = textBoxNbrPolice.Text;
                    string phone = textBoxPhone.Text;

                    try
                    {
                        db.addAdherent(nom, prenom, cin, nbrPolice, phone);
                        db.closeConnection();

                        clearFields();

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

        private void buttonAnnuler_Click_1(object sender, EventArgs e)
        {
            clearFields();

            defaultForm.openChildForm(new Clients());
        }
    }
}
