using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using TheArtOfDevHtmlRenderer.Adapters;
using System.IO;

namespace SFE
{
    public partial class PrintConsommation : Form
    {
        public String nom, prenom, nbrFacture, nbrPolice, dateOperation, periode, cnturAvant, cnturApres, QnttConsommee, tonPrix, prixTotal, taxe, montantAPayer;

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            printConsommation(this.panelPrint);
        }

        public PrintConsommation()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagearea.Width / 2) - (this.panelPrint.Width / 2), this.panelPrint.Location.Y);
        }
        private void printConsommation(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            panelPrint = pnl;
            getprintarea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();
        }
        private Bitmap memoryimg;
        private void getprintarea(Panel pnl)
        {
            memoryimg = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryimg, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        private void PrintConsommation_Load(object sender, EventArgs e)
        {
            labelNbrFactureOut.Text = nbrFacture;
            labelNomOut.Text = nom;
            labelPrenomOut.Text = prenom;
            labelNbrPoliceOut.Text = nbrPolice;
            labelDateOperationOut.Text = dateOperation;
            labelPeriodeOut.Text = periode;
            labelCnteurAvantOut.Text = cnturAvant;
            labelCnturApresOut.Text = cnturApres;
            labelQnttConsommeeOut.Text = QnttConsommee;
            labelTonPrixOut.Text = tonPrix;
            labelMontantTotalOut.Text = prixTotal;
            labelTaxeOut.Text = taxe;
            labelMontantAPayerOut.Text = montantAPayer;
        }
    }
}