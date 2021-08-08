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
    public partial class EndRentInvoice : Form
    {
        public string er_cusName, er_cusNIC, er_cusCNo, er_cusAdPay, er_vehicleID, er_startMileage, er_endMileage, er_startDate, er_endDate, er_totalPrice, er_finalPayment;

        private void btn_finalConfirm_Click(object sender, EventArgs e)
        {
            Print(this.panelEndRent);
        }

       

        private void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            panelEndRent = pnl;
            getprintarea(pnl);
            printPreviewDialog2.Document = printDocument2;
            printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument2_PrintPage);
            printPreviewDialog2.ShowDialog();
        }

        private Bitmap memoryimg;
        private void getprintarea(Panel pnl)
        {
            memoryimg = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryimg, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagearea.Width / 2) - (this.panelEndRent.Width / 2), this.panelEndRent.Location.Y);
        }

        private void EndRentInvoice_Load(object sender, EventArgs e)
        {
            lbl_erName.Text = er_cusName;
            lbl_erNIC.Text = er_cusNIC;
            lbl_erCNo.Text = er_cusCNo;
            lbl_erAPay.Text = er_cusAdPay;
            lbl_erVID.Text = er_vehicleID;
            lbl_erSM.Text = er_startMileage;
            lbl_erEM.Text = er_endMileage;
            lbl_erSD.Text = er_startDate;
            lbl_erED.Text = er_endDate;
            lbl_erTPay.Text = er_totalPrice;
            lbl_erFPay.Text = er_finalPayment;

        }

        public EndRentInvoice()
        {
            InitializeComponent();
        }
    }
}
