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
    public partial class US_OnRent : UserControl
    {
        public US_OnRent()
        {
            InitializeComponent();
            LoadTable();
        }
        private void LoadTable()
        {
            try
            {
                string MyConnection2 = "datasource= localhost; database=carrent; port=3306; username = root;";
                //Display query  
                string Query = "SELECT rentID AS 'Invoice ID', CustName AS 'Cust_Name', ConNum AS 'Contact No.', customerNIC AS 'Customer NIC', vehicleRegNum AS 'Vehical Number',driverNIC AS 'Driver NIC', fromDate AS 'Starting Date', toDate AS 'End Date',	totalCost AS 'Total Cost', advancePayment AS 'Advanced Payment',startMilage AS 'Start Mileage'  FROM rent WHERE rentType = 'OnRent'; ";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridViewOnRent.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                                                        // MyConn2.Close();  
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


        private void US_OnRent_Load(object sender, EventArgs e)
        {
           
        }

        private void dataGridViewOnRent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridViewOnRent.CurrentRow.Selected = true;
                txt_Invoice.Text = dataGridViewOnRent.Rows[e.RowIndex].Cells["Invoice ID"].Value.ToString();
                txt_CustName.Text = dataGridViewOnRent.Rows[e.RowIndex].Cells["Cust_Name"].Value.ToString();
                txt_NIC.Text = dataGridViewOnRent.Rows[e.RowIndex].Cells["Customer NIC"].Value.ToString();
                txt_ConNum.Text = dataGridViewOnRent.Rows[e.RowIndex].Cells["Contact No."].Value.ToString();
                txt_Advance.Text = dataGridViewOnRent.Rows[e.RowIndex].Cells["Advanced Payment"].Value.ToString();
                txt_VehRegNo.Text = dataGridViewOnRent.Rows[e.RowIndex].Cells["Vehical Number"].Value.ToString();
                cmb_Driver.Text = dataGridViewOnRent.Rows[e.RowIndex].Cells["Driver NIC"].Value.ToString();
                txtTotalCost.Text = dataGridViewOnRent.Rows[e.RowIndex].Cells["Total Cost"].Value.ToString();
                txt_StartMile.Text = dataGridViewOnRent.Rows[e.RowIndex].Cells["Start Mileage"].Value.ToString();
                gunaStartDate.Text = dataGridViewOnRent.Rows[e.RowIndex].Cells["Starting Date"].Value.ToString();
                gunaEndDate.Text = dataGridViewOnRent.Rows[e.RowIndex].Cells["End Date"].Value.ToString();
            }
        }

        
        private void btn_EndRent_Click(object sender, EventArgs e)
        {
            if (txt_orFP.Text != "")
            {
                int final = int.Parse(txt_orFP.Text);
                int amount = int.Parse(txtTotalCost.Text) - int.Parse(txt_Advance.Text);
                if (final < amount)
                {
                    MessageBox.Show("Error with Final Payment Amount", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int bal = final - amount;
                    EndRentInvoice endInvoice = new EndRentInvoice();
                    endInvoice.InvId = txt_Invoice.Text;
                    endInvoice.Name = txt_CustName.Text;
                    endInvoice.NIC = txt_NIC.Text;
                    endInvoice.ConNum = txt_ConNum.Text;
                    endInvoice.VehID = txt_VehRegNo.Text;
                    endInvoice.Driver = cmb_Driver.Text;
                    endInvoice.StartDate = gunaStartDate.Text;
                    endInvoice.EndDate = gunaEndDate.Text;
                    endInvoice.Advance = txt_Advance.Text;
                    endInvoice.StartMileage = txt_StartMile.Text;
                    endInvoice.EndMile = txt_EndMile.Text;
                    endInvoice.Cost = txtTotalCost.Text;
                    endInvoice.Final = txt_orFP.Text;
                    endInvoice.Balance = bal + "";
                    endInvoice.ShowDialog();
                    LoadTable();
                }
            }
            else
            {
                MessageBox.Show("Enter Final Payment Amount", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Calc_Click(object sender, EventArgs e)
        { 
            if(txt_EndMile.Text=="" )
            {
                MessageBox.Show("Please enter the End Mileage", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_EndRent.Enabled = false;
            }
            else if(int.Parse(txt_StartMile.Text)> int.Parse(txt_EndMile.Text))
            {
                MessageBox.Show("Invalid End Mileage", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_EndRent.Enabled = false;
            }
            else
            {
                try
                {
                    string Query = "Select * from vehicle where regNum='"+txt_VehRegNo.Text+"'";
                    MySqlConnection con = new DbConnection().getDb;
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(Query, con);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    int noDays;
                    TimeSpan difference = gunaEndDate.Value.AddDays(1).Date - gunaStartDate.Value.Date;
                    noDays = (int)difference.TotalDays;
                    int perDay=0;
                    int perExtra=0;
                    int freeMile=0;
                    int startMile = int.Parse(txt_StartMile.Text);
                    int endMile = int.Parse(txt_EndMile.Text);
                    int dif = endMile - startMile;
                    int total;
                    while (dr.Read())
                    {
                        
                        perDay = dr.GetInt32("pricePerDay");
                        perExtra = dr.GetInt32("pricePerExtraKM");
                        freeMile = dr.GetInt32("freeMilage");
                    }

                    if (dif > (freeMile * noDays) && cmb_Driver.Text == "")
                    {
                        total = (perDay * noDays) + (dif - (freeMile * noDays))*perExtra;
                    }
                    else if (dif > (freeMile * noDays) && cmb_Driver.Text != "")
                    {
                        total = (3000 * noDays) + (perDay * noDays) + (dif - (freeMile * noDays))*perExtra;
                    }
                    else
                    {
                        total = (perDay * noDays);
                    }
                    //MessageBox.Show("days"+noDays+",perday:"+perDay+",perextra:"+perExtra+"freemile:"+freeMile, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTotalCost.Text = total + "";
                    btn_EndRent.Enabled = true;
                    
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
}
