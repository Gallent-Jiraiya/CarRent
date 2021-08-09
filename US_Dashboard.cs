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
    public partial class US_Dashboard : UserControl
    {
        public US_Dashboard()
        {
            InitializeComponent();
            AvailCars();
            TotCars();
            TotDrivers();
            ResToday();
            ResTom();
            ResTwoDays();

        }
        private void AvailCars()
        {
            try
            {
                MySqlConnection con = new DbConnection().getDb;
                con.Open();
                String Query = "Select  * From vehicle WHERE regNum NOT IN(SELECT vehicleRegNum FROM rent WHERE rentType='OnRent'  )";
                MySqlCommand cmd = new MySqlCommand(Query, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    i++;
                }
                lblAvaCars.Text = i + "";
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
        private void TotCars()
        {
            try
            {
                MySqlConnection con = new DbConnection().getDb;
                con.Open();
                String Query = "Select  * From vehicle";
                MySqlCommand cmd = new MySqlCommand(Query, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    i++;
                }
                lbl_TotCars.Text = i + "";
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
        private void TotDrivers()
        {
            try
            {
                MySqlConnection con = new DbConnection().getDb;
                con.Open();
                String Query = "Select  * From driver";
                MySqlCommand cmd = new MySqlCommand(Query, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    i++;
                }
                lbl_TotDrivers.Text = i + "";
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
        private void ResToday()
        {
            try
            {
                MySqlConnection con = new DbConnection().getDb;
                con.Open();
                string tomo = DateTime.Now.AddDays(0).Date.ToString("yyyyMMdd");
                String Query = "SELECT * FROM rent WHERE fromDate='" + tomo + "'AND rentType='Reserved' ";
                MySqlCommand cmd = new MySqlCommand(Query, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    i++;
                }
                lbl_ResToday.Text = i + "";
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
        private void ResTom()
        {
            try
            {
                MySqlConnection con = new DbConnection().getDb;
                con.Open();
                string tomo = DateTime.Now.AddDays(1).Date.ToString("yyyyMMdd");
                String Query = "SELECT * FROM rent WHERE fromDate='" + tomo + "'AND rentType='Reserved'  ";
                MySqlCommand cmd = new MySqlCommand(Query, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    i++;
                }
                lbl_ResTomo.Text = i + "";
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
        private void ResTwoDays()
        {
            try
            {
                MySqlConnection con = new DbConnection().getDb;
                con.Open();
                string tomo = DateTime.Now.AddDays(2).Date.ToString("yyyyMMdd");
                String Query = "SELECT * FROM rent WHERE fromDate='" + tomo + "'AND rentType='Reserved'  ";
                MySqlCommand cmd = new MySqlCommand(Query, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    i++;
                }
                lbl_ResTwo.Text = i + "";
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
