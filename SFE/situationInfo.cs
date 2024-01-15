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
    public partial class situationInfo : Form
    {
        public situationInfo()
        {
            InitializeComponent();
        }

        private void situationInfo_Load(object sender, EventArgs e)
        {
            try
            {
                DataAccess db = new DataAccess();

                this.dataGridViewMontantDue.Rows.Clear();

                SqlDataReader dr = db.getClientConsommation(Clients.AdherentId);
                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        this.dataGridViewMontantDue.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6], dr[7], dr[8], dr[9], dr[10], dr[11]);
                    }
                }

                db.closeConnection();

                this.dataGridViewMontantPayer.Rows.Clear();

                SqlDataReader dr2 = db.getClientReglement(Clients.AdherentId);
                if (dr2.HasRows == true)
                {
                    while (dr2.Read())
                    {
                        this.dataGridViewMontantPayer.Rows.Add(dr2[0], dr2[1], dr2[2], dr2[3], dr2[4], dr2[5], dr2[6], dr2[7]);
                    }
                }

                db.closeConnection();

                SqlDataReader dr3 = db.getClientSituation(Clients.AdherentId);
                if (dr3.HasRows == true)
                {
                    while (dr3.Read())
                    {
                        textBoxTotalDue.Text = dr3[2].ToString();
                        textBoxTotalPayer.Text = dr3[3].ToString();
                        textBoxReste.Text = dr3[4].ToString();
                        textBoxDateOperation.Text = DateTime.Now.ToString("M/d/yyyy");
                    }
                }

                db.closeConnection();

                SqlDataReader dr4 = db.getClientNbrPolice(Clients.AdherentId);
                if (dr4.HasRows == true)
                {
                    while (dr4.Read())
                    {
                        textBoxNbrPolice.Text = dr4[0].ToString();
                    }
                }

                db.closeConnection();

                loadClientName();
            }
            catch (Exception)
            {
                functions.errorMsgBox();
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

        private void buttonAnnuler_Click_1(object sender, EventArgs e)
        {
            defaultForm.openChildForm(new Clients());
        }
    }
}
