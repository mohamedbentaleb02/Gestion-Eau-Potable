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
    public partial class situationGlobale : Form
    {
        public situationGlobale()
        {
            InitializeComponent();
        }

        private void situationGlobale_Load(object sender, EventArgs e)
        {
            try
            {
                DataAccess db = new DataAccess();

                SqlDataReader dr = db.loadSituationGlobal();
                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        this.dataGridViewStituationGlobale.Rows.Add(dr[0], dr[1], dr[7], dr[5], dr[6], dr[2], dr[3], dr[4]);
                    }
                    didntPay();
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
            string motCle = textBoxSearchBar.Text;
            try
            {
                DataAccess db = new DataAccess();

                this.dataGridViewStituationGlobale.Rows.Clear();

                SqlDataReader dr = db.searchClientInSituation(motCle);
                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        this.dataGridViewStituationGlobale.Rows.Add(dr[0], dr[1], dr[7], dr[5], dr[6], dr[2], dr[3], dr[4]);
                    }
                    didntPay();
                }
                else
                {
                    functions.tableVide();
                    situationGlobale_Load(sender, e);
                }

                db.closeConnection();
                textBoxSearchBar.Text = "";
            }
            catch (Exception)
            {
                functions.errorMsgBox();
                textBoxSearchBar.Text = "";
            }
        }

        private void didntPay()
        {
            try
            {
                foreach (DataGridViewRow row in dataGridViewStituationGlobale.Rows)
                {
                    string reste = row.Cells["reste"].Value.ToString();

                    if (getReste(reste) > 0)
                    {
                        row.Cells["nom"].Style.ForeColor = Color.Red;
                        row.Cells["prenom"].Style.ForeColor = Color.Red;
                        row.Cells["nbr_police"].Style.ForeColor = Color.Red;
                    }
                }
            }
            catch (Exception)
            {
                functions.errorMsgBox();
            }
        }

        private float getReste(string reste)
        {
            float rest;
            float.TryParse(reste, out rest);

            return rest;
        }

        public static string AdherentId;
        private void dataGridViewStituationGlobale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewStituationGlobale.Rows[e.RowIndex];
                AdherentId = row.Cells["adherent_id"].Value.ToString();
                Clients.AdherentId = AdherentId;
            }
        }

        private void découvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsRegSitBar.tab = 3;
            defaultForm.openChildForm(new ConsRegSitBar());
            ConsRegSitBar.openChildFormConsRegSit(new situationInfo());
        }
    }
}
