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
    public partial class US_Search : UserControl
    {
        public US_Search()
        {
            InitializeComponent();
            loadVehicles("SELECT * FROM `vehicle`",1);
            TimeSpan difference = guna2DateTimePicker2.Value.AddDays(1).Date - guna2DateTimePicker1.Value.Date;

            txt_NoDays.Text = "" + (int)difference.TotalDays;

        }

        public void loadVehicles(String Query,int days)
        {
            try
            {
                MySqlConnection con = new DbConnection().getDb;
                con.Open();
                MySqlCommand cmd = new MySqlCommand(Query, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (flowLayoutPanel1.Controls.Count > 0)
                {

                    flowLayoutPanel1.Controls.Clear();

                }
                String startdate = guna2DateTimePicker1.Value.Date.ToString("yyyyMMdd");
                String endDate = guna2DateTimePicker2.Value.Date.ToString("yyyyMMdd");
                while (dr.Read())
                {
                    SearchVehicle item = new SearchVehicle();
                    item.Picture = dr.GetString("picture");
                    item.Passengers = dr.GetString("passengers");
                    item.RegNo = dr.GetString("regNum");
                    item.Year = dr.GetString("modelYear");
                    item.AC = dr.GetString("airCondition");
                    item.Transmission = dr.GetString("transmissionType");
                    item.Price = int.Parse(dr.GetString("pricePerDay"));
                    item.Days = days;
                    item.Mileage = dr.GetString("freeMilage");
                    item.PerKm = int.Parse(dr.GetString("pricePerExtraKM"));
                    item.Model = dr.GetString("brand");
                    item.Luggage = dr.GetString("Luggage");
                    item.StartDay = startdate;
                    item.EndDay = endDate;

                    if (flowLayoutPanel1.Controls.Count < 0)
                    {
                        flowLayoutPanel1.Controls.Clear();
                    }
                    else
                    {
                        flowLayoutPanel1.Controls.Add(item);
                    }
                }
            }
            catch (IOException e)
            {
                // Extract some information from this exception, and then
                // throw it to the parent method.
                if (e.Source != null)
                    Console.WriteLine("IOException source: {0}", e.Source);
                throw;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int days = int.Parse(txt_NoDays.Text);
            String search = txt_Search.Text;
            string trans=null;
            if (rad_Auto.Checked)
            {
                trans = "Auto";
            }
            if (rad_Manual.Checked)
            {
                trans = "Manual";
            }
            String startdate=guna2DateTimePicker1.Value.Date.ToString("yyyyMMdd");
            String endDate=guna2DateTimePicker2.Value.Date.ToString("yyyyMMdd");
            string sql = "SELECT * FROM vehicle WHERE regNum NOT IN(SELECT vehicleRegNum FROM rent WHERE  '"+startdate+"'  BETWEEN fromDate AND toDate OR '"+endDate+"'  BETWEEN fromDate AND toDate)";
            loadVehicles(sql, days);

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (guna2DateTimePicker1.Value < (DateTime.Now.AddDays(0).Date))
            {
                 MessageBox.Show("Start Date is Invalid");
                guna2DateTimePicker1.Value = DateTime.Now.Date;
                guna2DateTimePicker2.Enabled = false;
                
            }
            else
            {
                guna2DateTimePicker2.Enabled = true;
            }
        }

        private void guna2DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (guna2DateTimePicker2.Value < guna2DateTimePicker1.Value)
            {
                MessageBox.Show("End Date is Invalid");
                guna2DateTimePicker2.Value = guna2DateTimePicker1.Value;
                
            }
            else
            {
                TimeSpan difference = guna2DateTimePicker2.Value.AddDays(1).Date - guna2DateTimePicker1.Value.Date;
                txt_NoDays.Text = "" + (int)difference.TotalDays;
            }
        }
    }
    

}
