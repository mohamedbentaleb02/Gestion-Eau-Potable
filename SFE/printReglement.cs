using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SFE
{
    public partial class PrintReglement : Form
    {
        public String nbrRecu, nom, prenom, nbrPolice, montant, modePaiement, dateOperation, recu, observation;

        private void pictureBoxPrintReg_Click(object sender, EventArgs e)
        {
            printReglement(this.panelPrintReg);
        }

        private void PrintReglement_Load_1(object sender, EventArgs e)
        {
            labelRecuNumOut.Text = nbrRecu;
            labelNomOut.Text = nom;
            labelPrenomOut.Text = prenom;
            labelNbrPoliceOut.Text = nbrPolice;
            labelMontantOut.Text = montant;
            labelModePaiementOut.Text = modePaiement;
            labelDateOperationOut.Text = dateOperation;
            labelRecuOut.Text = recu;
            labelObservationOut.Text = observation;
        }

        public PrintReglement()
        {
            InitializeComponent();
        }

        private void printDocument2_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagearea.Width / 2) - (this.panelPrintReg.Width / 2), this.panelPrintReg.Location.Y);
        }
        private void printReglement(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            panelPrintReg = pnl;
            getprintarea(pnl);
            printPreviewDialog2.Document = printDocument2;
            printDocument2.PrintPage += new PrintPageEventHandler(printDocument2_PrintPage);
            printPreviewDialog2.ShowDialog();
        }

        private Bitmap memoryimg;
        private void getprintarea(Panel pnl)
        {
            memoryimg = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryimg, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }
    }
}
