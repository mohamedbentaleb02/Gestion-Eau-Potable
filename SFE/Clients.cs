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
    public partial class Clients : Form
    {
        //string sql = Helper.cnnString("appEau");

        public Clients()
        {
            InitializeComponent();
        }

        private void voirSituationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsRegSitBar.tab = 3;
            defaultForm.openChildForm(new ConsRegSitBar());
            ConsRegSitBar.openChildFormConsRegSit(new situationInfo());
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            defaultForm.openChildForm(new addClientForm());
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            defaultForm.openChildForm(new clientInfoForm());
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = functions.confirmationBox();

            if (result == DialogResult.Yes)
            {
                try
                {
                    DataAccess db = new DataAccess();

                    db.deleteClient(Clients.AdherentId);
                    db.closeConnection();

                    this.Clients_Load(sender, e);
                }
                catch (Exception)
                {
                    functions.errorMsgBox();
                }
            }
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            try
            {
                DataAccess db = new DataAccess();

                SqlDataReader dr = db.loadClients();
                if (dr.HasRows == true)
                {
                    this.dataGridViewClientsList.Rows.Clear();
                    while (dr.Read())
                    {
                        this.dataGridViewClientsList.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5]);
                    }
                }
                else
                {
                    functions.tableVide();
                }

                db.closeConnection();
            }
            catch (Exception)
            {
                functions.errorMsgBox();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccess db = new DataAccess();
                string motCle = textBoxSearchBar.Text;

                this.dataGridViewClientsList.Rows.Clear();

                SqlDataReader dr = db.searchClient(motCle);

                if (dr.HasRows == true)
                {
                    this.dataGridViewClientsList.Rows.Clear();
                    while (dr.Read())
                    {
                        this.dataGridViewClientsList.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5]);
                    }
                }
                else
                {
                    functions.tableVide();
                    Clients_Load(sender, e);
                }

                db.closeConnection();
                textBoxSearchBar.Text = "";
            }
            catch (Exception)
            {
                functions.errorMsgBox();
            }
        }

        public static string AdherentId;
        public static string adherentNbrPolice;
        private void dataGridViewClientsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewClientsList.Rows[e.RowIndex];
                AdherentId = row.Cells["id"].Value.ToString();
                adherentNbrPolice = row.Cells["num_police"].Value.ToString();
            }
        }

        private void histoireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsRegSitBar.tab = 1;
            defaultForm.openChildForm(new ConsRegSitBar());
            ConsRegSitBar.openChildFormConsRegSit(new ConsommationList());
        }

        private void ajouterUnPaiementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            defaultForm.openChildForm(new reglementForm());
        }

        private void histoireToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsRegSitBar.tab = 2;
            defaultForm.openChildForm(new ConsRegSitBar());
            ConsRegSitBar.openChildFormConsRegSit(new ReglementList());
        }

        private void créerUneFactureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            defaultForm.openChildForm(new consommationForm());
        }
    }
}
