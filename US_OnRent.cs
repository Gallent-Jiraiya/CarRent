using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void US_OnRent_Load(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "datasource= localhost; database=carrent; port=3306; username = root;";
                //Display query  
                string Query = "SELECT A.rentID AS 'Reservation ID', CONCAT(B.fName,' ', B.lName) AS 'Name', B.contactNo AS 'Contact No.', A.customerNIC AS 'Customer NIC', A.vehicleRegNum AS 'Vehical Number', A.fromDate AS 'Starting Date', A.toDate AS 'End Date', A.startMilage AS 'Start Mileage', A.endMilage AS 'End Mileage', A.advancePayment AS 'Advanced Payment', A.driverNIC AS 'Driver NIC' FROM rent A, customer B WHERE A.customerNIC=B.NIC AND A.rentType = 'OnRent'; ";
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewOnRent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewOnRent.CurrentRow.Selected = true;
            txt_orName.Text = dataGridViewOnRent.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            txt_orNIC.Text = dataGridViewOnRent.Rows[e.RowIndex].Cells["Customer NIC"].Value.ToString();
            txt_orCNo.Text = dataGridViewOnRent.Rows[e.RowIndex].Cells["Contact No."].Value.ToString();
            txt_orAdPay.Text = dataGridViewOnRent.Rows[e.RowIndex].Cells["Advanced Payment"].Value.ToString();
            txt_orVID.Text = dataGridViewOnRent.Rows[e.RowIndex].Cells["Vehical Number"].Value.ToString();
            txt_orSM.Text = dataGridViewOnRent.Rows[e.RowIndex].Cells["Start Mileage"].Value.ToString();
            txt_orEM.Text = dataGridViewOnRent.Rows[e.RowIndex].Cells["End Mileage"].Value.ToString();
            dtp_orStart.Text = dataGridViewOnRent.Rows[e.RowIndex].Cells["Starting Date"].Value.ToString();
            dtp_orEnd.Text = dataGridViewOnRent.Rows[e.RowIndex].Cells["End Date"].Value.ToString();
        }

        
        private void btn_EndRent_Click(object sender, EventArgs e)
        {
            EndRentInvoice endInvoice = new EndRentInvoice();
            endInvoice.er_cusName = txt_orName.Text;
            endInvoice.er_cusNIC = txt_orNIC.Text;
            endInvoice.er_cusCNo = txt_orCNo.Text;
            endInvoice.er_cusAdPay = txt_orAdPay.Text;
            endInvoice.er_vehicleID = txt_orVID.Text;
            endInvoice.er_startMileage = txt_orSM.Text;
            endInvoice.er_endMileage = txt_orEM.Text;
            endInvoice.er_startDate = dtp_orStart.Text;
            endInvoice.er_endDate = dtp_orEnd.Text;
            endInvoice.er_totalPrice = txt_orTP.Text;
            endInvoice.er_finalPayment = txt_orFP.Text;
            endInvoice.ShowDialog();
        }

        private void dataGridViewOnRent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
