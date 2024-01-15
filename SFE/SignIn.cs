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
    public partial class signIn : Form
    {
        public signIn()
        {
            InitializeComponent();
            textBoxPassword.UseSystemPasswordChar = true;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void show_password_Click(object sender, EventArgs e)
        {
            if (show_password.Checked) textBoxPassword.UseSystemPasswordChar = false;
            else textBoxPassword.UseSystemPasswordChar = true;
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccess db = new DataAccess();

                if (textBoxUsername.Text != string.Empty && textBoxPassword.Text != string.Empty)
                {
                    string username = textBoxUsername.Text;
                    string password = textBoxPassword.Text;

                    SqlDataReader dr = db.signIn(username, password);
                    if (dr.Read())
                    {
                        dr.Close();
                        this.Hide();

                        defaultForm defaultForm = new defaultForm();
                        defaultForm.ShowDialog();

                        this.Close();
                    }
                    else
                    {
                        dr.Close();
                        functions.invalidLogin();
                        textBoxPassword.Text = "";
                    }
                }
                else
                {
                    functions.cantBeEmpty();
                }
            }
            catch (Exception)
            {
                functions.errorMsgBox();
            }
            
        }
    }
}
