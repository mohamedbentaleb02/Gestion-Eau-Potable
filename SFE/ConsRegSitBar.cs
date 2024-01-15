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
    public partial class ConsRegSitBar : Form
    {
        public ConsRegSitBar()
        {
            InitializeComponent();

            switch(tab)
            {
                case 1:
                    buttonConsommation.Checked = true;
                    break;
                case 2:
                    buttonReglement.Checked = true;
                    break;
                case 3:
                    buttonSituation.Checked = true;
                    break;
                default:
                    break;
            }
        }

        public static int tab = 0;

        public static Form activeForm = null;
        public static void openChildFormConsRegSit(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMainConRegSit.Controls.Add(childForm);
            panelMainConRegSit.Tag = childForm;
            childForm.Show();
        }

        private void buttonConsommation_Click(object sender, EventArgs e)
        {
            tab = 1;
            openChildFormConsRegSit(new ConsommationList());
        }

        private void buttonReglement_Click(object sender, EventArgs e)
        {
            tab = 2;
            openChildFormConsRegSit(new ReglementList());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            tab = 3;
            openChildFormConsRegSit(new situationInfo());
        }
    }
}
