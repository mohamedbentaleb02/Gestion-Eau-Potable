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
    public partial class defaultForm : Form
    {
        public defaultForm()
        {
            InitializeComponent();
            buttonBoard.Checked = true;

            /*switch (section)
            {
                case 2:
                    buttonClients.Checked = true;
                    break;
                case 3:
                    buttonConsommation.Checked = true;
                    break;
                case 4:
                    buttonReglement.Checked = true;
                    break;
                case 5:
                    buttonSituation.Checked = true;
                    break;
                default:
                    buttonBoard.Checked = true;
                    break;
            }*/
        }

        //public static int section = 0;

        public static Form activeForm = null;
        public static void openChildForm( Form childForm)
        {
            if (activeForm != null) activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.Show();
        }

        private void buttonClients_Click(object sender, EventArgs e)
        {
            //section = 2;
            openChildForm(new Clients());
        }

        private void buttonBoard_Click(object sender, EventArgs e)
        {
            //section = 1;
            openChildForm(new Dashboard());
        }

        private void buttonConsommation_Click(object sender, EventArgs e)
        {
            //section = 3;
            openChildForm(new consommationForm());
        }

        private void buttonReglement_Click(object sender, EventArgs e)
        {
            //section = 4;
            openChildForm(new reglementForm());
        }

        private void defaultForm_Load(object sender, EventArgs e)
        {
            openChildForm(new Dashboard());
        }

        private void buttonSituation_Click(object sender, EventArgs e)
        {
            //section = 5;
            openChildForm(new situationGlobale());
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        { 
            this.Close();
        }
    }
}
