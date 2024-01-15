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
    public partial class ReglementList : Form
    {
        public ReglementList()
        {
            InitializeComponent();
        }

        private void ReglementList_Load(object sender, EventArgs e)
        {
            try
            {
                DataAccess db = new DataAccess();

                this.dataGridViewRegList.Rows.Clear();

                SqlDataReader dr = db.getClientReglement(Clients.AdherentId);
                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        this.dataGridViewRegList.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6], dr[7]);
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

        private void découvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsRegSitBar.openChildFormConsRegSit(new reglemetnInfo());
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
                    string id = reglementId;

                    db.deleteReglement(adherentId, id);
                    db.closeConnection();

                    this.ReglementList_Load(sender, e);
                }
                catch (Exception)
                {
                    functions.errorMsgBox();
                }
            }
        }

        public static string reglementId;
        private void dataGridViewRegList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewRegList.Rows[e.RowIndex];
                reglementId = row.Cells["id"].Value.ToString();
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

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            defaultForm.openChildForm(new reglementForm());
        }
    }
}
