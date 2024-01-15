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
    public partial class ConsommationList : Form
    {
        public ConsommationList()
        {
            InitializeComponent();
        }

        private void découvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsRegSitBar.openChildFormConsRegSit(new consommationInfo());
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = functions.confirmationBox();

            if (result == DialogResult.Yes)
            {
                try
                {
                    DataAccess db = new DataAccess();

                    string adherentId = Clients.AdherentId;
                    string id = consommationId;

                    db.deleteConsommation(adherentId, id);
                    db.closeConnection();

                    this.ConsommationList_Load(sender, e);
                }
                catch (Exception)
                {
                    functions.errorMsgBox();
                }
            }
        }

        private void ConsommationList_Load(object sender, EventArgs e)
        {
            try
            {
                DataAccess db = new DataAccess();

                this.dataGridViewConsList.Rows.Clear();

                SqlDataReader dr = db.getClientConsommation(Clients.AdherentId);
                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        this.dataGridViewConsList.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6], dr[7], dr[8], dr[9], dr[10], dr[11]);
                    }
                }
                else
                {
                    functions.tableVide();
                }

                db.closeConnection();

                loadClientName();
            }
            catch (Exception)
            {
                functions.errorMsgBox();
            }
        }

        public static string consommationId;
        private void dataGridViewConsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewConsList.Rows[e.RowIndex];
                consommationId = row.Cells["id"].Value.ToString();
            }
        }

        private void loadClientName()
        {
            DataAccess db = new DataAccess();

            SqlDataReader dr = db.loadClientNomPrenom(Clients.AdherentId);
            if (dr.HasRows == true)
            {
                while (dr.Read())
                {
                    textBoxNom.Text = dr[0].ToString() + " " + dr[1].ToString();
                }
            }

            db.closeConnection();
        }

        //public static string adherent;
        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            //adherent = Clients.AdherentId;
            //defaultForm.section = 3;
            defaultForm.openChildForm(new consommationForm());
        }
    }
}
