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
    public partial class Invoice : Form
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
            set { _cost = value;  lblTotal.Text = value+""; }
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



        public Invoice()
        {
            InitializeComponent();
            invoiceID();
        }
        private void invoiceID()
        {
            try
            {
                String Query= "SELECT rentID FROM rent ORDER BY rentID DESC";

                MySqlConnection con = new DbConnection().getDb;
                con.Open();
                MySqlCommand cmd = new MySqlCommand(Query, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                lblInvoice.Text = (dr.GetInt32("rentID")+1) + "";

                
            }
            catch (IOException ex)
            {
                // Extract some information from this exception, and then
                // throw it to the parent method.
                if (ex.Source != null)
                    Console.WriteLine("IOException source: {0}", ex.Source);
                throw;
            }
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

        private void Invoice_Load(object sender, EventArgs e)
        {
            

        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            Print(this.panelPrintInvoice);
            string Query;
            if (lblStartMileage.Text == "")//reservation
            {
                Query= "insert into rent (CustName,customerNIC,ConNum,vehicleRegNum,rentType,fromDate,toDate,driverNIC,totalCost,advancePayment,userName) " +
                    "values('" + lblName.Text + "','" + lblNIC.Text + "','" + lblCNo.Text + "','" + lblVehID.Text + "','Reserved','" + lblStartDate.Text + "','" + lblEndDate.Text + "','" + lblDriver.Text + "','" + int.Parse(lblTotal.Text) + "','" + int.Parse(lblAdvance.Text) + "','Admin');";
                
            }
            else //rent
            {
                Query = "insert into rent (CustName,customerNIC,ConNum,vehicleRegNum,rentType,fromDate,toDate,driverNIC,totalCost,advancePayment,startMilage,userName) " +
                    "values('" + lblName.Text + "','" + lblNIC.Text + "','" + lblCNo.Text + "','" + lblVehID.Text + "','OnRent','" + lblStartDate.Text + "','" + lblEndDate.Text + "','" + lblDriver.Text + "','" + int.Parse(lblTotal.Text) + "','" + int.Parse(lblAdvance.Text) + "','" + int.Parse(lblStartMileage.Text) + "','Admin');";

            }
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

        private void panelPrintInvoice_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
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
