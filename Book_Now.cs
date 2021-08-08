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
                String Query = "SELECT * FROM driver WHERE NIC NOT IN(SELECT driverNIC FROM rent WHERE  '" + startDate + "'  BETWEEN fromDate AND toDate OR '" + endDate + "'  BETWEEN fromDate AND toDate)";
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
    }
}
