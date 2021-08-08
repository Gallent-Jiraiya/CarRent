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
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CarRent
{
    public partial class US_Vehicles : UserControl
    {
        public US_Vehicles()
        {
            InitializeComponent();
        }

        private void US_Vehicles_Load(object sender, EventArgs e)
        {
            loadVehicles();
        }
        private void loadVehicles()
        {
            try
            {
                
                MySqlConnection con = new DbConnection().getDb;
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM `vehicle`",con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    ListVehicle item = new ListVehicle();
                    item.Picture = dr.GetString("picture");
                    item.Passengers = dr.GetString("passengers");
                    item.RegNo = dr.GetString("regNum");
                    item.Year = dr.GetString("modelYear");
                    item.AC = dr.GetString("airCondition");
                    item.Transmission = dr.GetString("transmissionType");
                    item.Price = dr.GetString("pricePerDay");
                    item.Mileage = dr.GetString("freeMilage");
                    item.PerKm = dr.GetString("pricePerExtraKM");
                    item.Model = dr.GetString("brand");
                    item.Luggage = dr.GetString("Luggage");

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
            catch { }
        }

       

        public void editPanel(US_VehDet item)
        {
            if (panel1.Controls.Count < 0)
            {
                panel1.Controls.Clear();
            }
            else
            {
                panel1.Controls.Add(item);
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            US_VehDet pan = new US_VehDet();
            panel1.Controls.Add(pan);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
