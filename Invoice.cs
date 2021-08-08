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

namespace CarRent
{
    public partial class Invoice : Form
    {
        public string cusName, cusNIC, cusCNo, cusAdPay, vehicleID, startMileage, startDate, endDate;
        public Invoice()
        {
            InitializeComponent();
        }

        private void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            panelPrintInvoice = pnl;
            getprintarea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();
        }

        private Bitmap memoryimg;

        private void getprintarea(Panel pnl)
        {
            memoryimg = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryimg, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        private void panelPrintInvoice_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void lblED_Click(object sender, EventArgs e)
        {

        }

        private void lblSD_Click(object sender, EventArgs e)
        {

        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            lblName.Text = cusName;
            lblNIC.Text = cusNIC;
            lblCNo.Text = cusCNo;
            lblAPay.Text = cusAdPay;
            lblVID.Text = vehicleID;
            lblSM.Text = startMileage;
            lblSD.Text = startDate;
            lblED.Text = endDate;

        }

        private void lblSM_Click(object sender, EventArgs e)
        {

        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            Print(this.panelPrintInvoice);
        }

        private void panelPrintInvoice_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void lblVID_Click(object sender, EventArgs e)
        {

        }

        private void lblAPay_Click(object sender, EventArgs e)
        {

        }

        private void lblCNo_Click(object sender, EventArgs e)
        {

        }

        private void lblNIC_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagearea.Width / 2) - (this.panelPrintInvoice.Width / 2), this.panelPrintInvoice.Location.Y);
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
