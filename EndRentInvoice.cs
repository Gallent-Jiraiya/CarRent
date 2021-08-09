using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRent
{
    public partial class EndRentInvoice : Form
    {
        
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; lblName.Text = value; }
        }
        private String _nic;

        public String NIC
        {
            get { return _nic; }
            set { _nic = value; lblNIC.Text = value; }
        }
        private String _conNumber;

        public String ConNum
        {
            get { return _conNumber; }
            set { _conNumber = value; lblCNo.Text = value; }
        }

        private string _vehID;

        public string VehID
        {
            get { return _vehID; }
            set { _vehID = value; lblVehID.Text = value; }
        }

        private string _driver;

        public string Driver
        {
            get { return _driver; }
            set { _driver = value; lblDriver.Text = value; }
        }

        private String _startDate;

        public String StartDate
        {
            get { return _startDate; }
            set { _startDate = value; lblStartDate.Text = value; }
        }

        private string _endDate;

        public string EndDate
        {
            get { return _endDate; }
            set { _endDate = value; lblEndDate.Text = value; }
        }

        private string _cost;

        public string Cost
        {
            get { return _cost; }
            set { _cost = value; lblTotal.Text = value + ""; }
        }

        private string _advance;

        public string Advance
        {
            get { return _advance; }
            set { _advance = value; lblAdvance.Text = value + ""; }
        }
        private string _StartMileage;

        public string StartMileage
        {
            get { return _StartMileage; }
            set { _StartMileage = value; lblStartMileage.Text = value + ""; }
        }
        private String _invID;
        private string _endMile;

        public string EndMile
        {
            get { return _endMile; }
            set { _endMile = value; lbl_EndMile.Text = value; }
        }
        private string _final;

        public string Final
        {
            get { return _final; }
            set { _final = value; lbl_Final.Text = value; }
        }
        private string _balance;

        public string Balance
        {
            get { return _balance; }
            set { _balance = value; lbl_Bal.Text = value; }
        }



        public String InvId
        {
            get { return _invID; }
            set { _invID = value; lblInvoice.Text = value + ""; }
        }


        private void btn_finalConfirm_Click(object sender, EventArgs e)
        {
            Print(this.panelEndRent);
            string Query;
            Query = "update rent set rentType='Completed',totalCost='" + _cost + "',endMilage='" + _endMile + "',finalPayment='" + _final + "',balance='" + _balance + "' where rentID='" + _invID + "';";
            try
            {
                MySqlConnection con = new DbConnection().getDb;
                con.Open();
                MySqlCommand cmd = new MySqlCommand(Query, con);
                MySqlDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {


                }
                con.Close();
            }
            catch (IOException ex)
            {
                // Extract some information from this exception, and then
                // throw it to the parent method.
                if (ex.Source != null)
                    Console.WriteLine("IOException source: {0}", ex.Source);
                throw;
            }
            this.Dispose();
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
           
        }

        public EndRentInvoice()
        {
            InitializeComponent();
        }
    }
}
