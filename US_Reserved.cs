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
    public partial class US_Reserved : UserControl
    {
        public US_Reserved()
        {
            InitializeComponent();
            loadTable();
        }

        private void US_Reserved_Load(object sender, EventArgs e)
        {
            
        }
        private void loadTable()
        {
            try
            {
                string MyConnection2 = "datasource= localhost; database=carrent; port=3306; username = root;";
                //Display query  
                string Query = "SELECT rentID AS 'Reservation ID', CustName AS 'Cust_Name', ConNum AS 'Contact No.', customerNIC AS 'Customer NIC', vehicleRegNum AS 'Vehical Number',driverNIC AS 'Driver NIC', fromDate AS 'Starting Date', toDate AS 'End Date',	totalCost AS 'Total Cost', advancePayment AS 'Advanced Payment'  FROM rent WHERE rentType = 'Reserved'; ";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable; 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.CurrentRow.Selected = true;
                txt_Invoice.Text = dataGridView1.Rows[e.RowIndex].Cells["Reservation ID"].Value.ToString();
                txt_CustName.Text = dataGridView1.Rows[e.RowIndex].Cells["Cust_Name"].Value.ToString();
                txt_NIC.Text = dataGridView1.Rows[e.RowIndex].Cells["Customer NIC"].Value.ToString();
                txt_ConNum.Text = dataGridView1.Rows[e.RowIndex].Cells["Contact No."].Value.ToString();
                txt_Advance.Text = dataGridView1.Rows[e.RowIndex].Cells["Advanced Payment"].Value.ToString();
                txt_VehRegNo.Text = dataGridView1.Rows[e.RowIndex].Cells["Vehical Number"].Value.ToString();
                cmb_Driver.Text = dataGridView1.Rows[e.RowIndex].Cells["Driver NIC"].Value.ToString();
                txtTotalCost.Text = dataGridView1.Rows[e.RowIndex].Cells["Total Cost"].Value.ToString();
                gunaStartDate.Text = dataGridView1.Rows[e.RowIndex].Cells["Starting Date"].Value.ToString();
                gunaEndDate.Text = dataGridView1.Rows[e.RowIndex].Cells["End Date"].Value.ToString();
            }
        }

        

        private void btn_ReleaseVehicle_Click(object sender, EventArgs e)
        {
            if (txt_StartMile.Text == "")
            {
                MessageBox.Show("Please enter the Start Mileage", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                inv.StartMileage = txt_StartMile.Text;
                inv.InvId = txt_Invoice.Text;
                inv.Update = true;
                inv.ShowDialog();
                loadTable();
            }
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new DbConnection().getDb;
                con.Open();
                String Query = Query = "update rent set rentType='Canceled'where rentID='" + txt_Invoice.Text + "';";
                MySqlCommand cmd = new MySqlCommand(Query, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                { 
                }
                MessageBox.Show("Reservation Cancelled",this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadTable();
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
