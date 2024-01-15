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
    public partial class Dashboard : Form
    {
        string sql = Helper.cnnString("appEau");

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            try
            {
                DataAccess db = new DataAccess();

                SqlDataReader drd = db.loadConsommationYears();
                while (drd.Read())
                {
                    yearOfConsommation.Items.Add(drd["Year"].ToString());
                }
            }
            catch (Exception)
            {
                functions.errorMsgBox();
            }

            DateTime myDateTime = DateTime.Now;
            string year2 = myDateTime.Year.ToString();
            yearOfConsommation.Text = year2;
        }

        private void yearOfConsommation_SelectedValueChanged(object sender, EventArgs e)
        {
            // to do: wrape this up inside a function of DataAccess class
            SqlConnection conn = new SqlConnection(sql);
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = conn.CreateCommand();
            string year = yearOfConsommation.Text;
            cmd.CommandText = "SELECT C.id_mois,Pc.mois as Periode,SUM(qntt_consommee) as Quantite FROM consommation C INNER JOIN periode_consommation Pc on C.id_mois=Pc.id_mois WHERE operation_date LIKE '%" + year + "%' GROUP BY C.id_mois,Pc.mois ";
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();

            conn.Open();
            da.Fill(ds);
            this.chartConsommation.DataSource = ds.Tables[0];

            //Mapping a field with x-value of chart
            this.chartConsommation.Series[0].XValueMember = "Periode";

            //Mapping a field with y-value of Chart
            this.chartConsommation.Series[0].YValueMembers = "Quantite";

            //Bind the DataTable with Chart
            this.chartConsommation.DataBind();

            conn.Close();
        }

    }
}
