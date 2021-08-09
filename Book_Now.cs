using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRent
{
    public partial class Book_Now : Form
    {
        public Book_Now()
        {
            InitializeComponent();


        }

        private String _regNo;
        private String _name;
        private String _contactNum;
        private String _Driver;
        private int _total;
        private int _advance;
        private int _mileage;

        private int _price;

        public int Price
        {
            get { return _price; }
            set { _price = value;  }
        }

        private int _days;

        public int Days
        {
            get { return _days; }
            set { _days = value;
                txtTotalCost.Text = (value * _price) + ""; }
        }

        public String RegNo
        {
            get { return _regNo; }
            set { _regNo = value;
                txt_VehRegNo.Text = "" + value; }
        }
        

        private DateTime _StartDate;

        public DateTime StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value;
                gunaStartDate.Value = value;
            }
        }
        private DateTime _endDate;

        public DateTime EndDate
        {
            get { return _endDate; }
            set { _endDate = value;
                gunaEndDate.Value = value; }
        }

        private void Book_Now_Load(object sender, EventArgs e)
        {
            
        }
        public void DriverCombo()
        {
            try
            {
                MySqlConnection con = new DbConnection().getDb;
                con.Open();
                String startDate = _StartDate.Date.ToString("yyyyMMdd");
                String endDate = _endDate.Date.ToString("yyyyMMdd");
                String Query = "SELECT * FROM driver WHERE NIC NOT IN(SELECT driverNIC FROM rent WHERE  ('" + startDate + "'  BETWEEN fromDate AND toDate) OR ('" + endDate + "'  BETWEEN fromDate AND toDate))";
                MySqlCommand cmd = new MySqlCommand(Query, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                cmb_Driver.Items.Clear();
                while (dr.Read())
                {
                    cmb_Driver.Items.Add(dr.GetString("NIC"));
                }
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

        private void cmb_Driver_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cmb_Driver_TextChanged(object sender, EventArgs e)
        {
            if (cmb_Driver.Text != null)
            {
                txtTotalCost.Text = (_days * _price + 3000) + "";
            }
            if (cmb_Driver.Text == "")
            {
                txtTotalCost.Text = (_days * _price) + "";
            }
        }

        private void cmb_Driver_KeyDown(object sender, KeyEventArgs e)
        {
            if (cmb_Driver.Text != null)
            {
                txtTotalCost.Text = (_days * _price + 3000) + "";
            }
            if(cmb_Driver.Text=="")
            {
                txtTotalCost.Text = (_days * _price) + "";
            }
        }

        private void btn_Rent_Click(object sender, EventArgs e)
        {
            if (txt_CustName.Text == "")
            {
                MessageBox.Show("Please enter the Customer name", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_NIC.Text == "")
            {
                MessageBox.Show("Please enter the NIC number", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_ConNum.Text == "")
            {
                MessageBox.Show("Please enter the Contact Number", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_Advance.Text == "")
            {
                MessageBox.Show("Please enter the Advance Payment", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_StartMile.Text == "")
            {
                MessageBox.Show("Please enter the Start Mileage", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Invoice inv = new Invoice();
                inv.Name = txt_CustName.Text;
                inv.NIC = txt_NIC.Text;
                inv.ConNum=txt_ConNum.Text;
                inv.VehID=txt_VehRegNo.Text;
                inv.Driver=cmb_Driver.Text;
                inv.StartDate= gunaStartDate.Value.Date.ToString("yyyyMMdd");
                inv.EndDate= gunaEndDate.Value.Date.ToString("yyyyMMdd");
                inv.Cost = txtTotalCost.Text;
                inv.Advance=txt_Advance.Text;
                inv.StartMileage = txt_StartMile.Text;
                inv.invoiceID();
                inv.Show();
            }

        }

        private void btn_Reserve_Click(object sender, EventArgs e)
        {
            if (txt_CustName.Text == "")
            {
                MessageBox.Show("Please enter the Customer name", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_NIC.Text == "")
            {
                MessageBox.Show("Please enter the NIC number", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_ConNum.Text == "")
            {
                MessageBox.Show("Please enter the Contact Number", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_Advance.Text == "")
            {
                MessageBox.Show("Please enter the Advance Payment", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Invoice inv = new Invoice();
                inv.Name = txt_CustName.Text;
                inv.NIC = txt_NIC.Text;
                inv.ConNum = txt_ConNum.Text;
                inv.VehID = txt_VehRegNo.Text;
                inv.Driver = cmb_Driver.Text;
                inv.StartDate = gunaStartDate.Value.Date.ToString("yyyyMMdd");
                inv.EndDate = gunaEndDate.Value.Date.ToString("yyyyMMdd");
                inv.Cost = txtTotalCost.Text;
                inv.Advance = txt_Advance.Text;
                inv.invoiceID();
                inv.Show();
            }
        }
    }
}
