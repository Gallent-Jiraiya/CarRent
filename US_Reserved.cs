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
    public partial class US_Reserved : UserControl
    {
        public US_Reserved()
        {
            InitializeComponent();
        }

        private void US_Reserved_Load(object sender, EventArgs e)
        {
           /* MySqlConnection con = new MySqlConnection("datasource= localhost; database=carrent; port=3306; username = root;");
            con.Open();
            dataGridView1.DataSource = null;
            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from rent", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();*/

            try
            {
                string MyConnection2 = "datasource= localhost; database=carrent; port=3306; username = root;";
                //Display query  
                string Query = "SELECT A.rentID AS 'Reservation ID', B.fName AS 'Name', B.contactNo AS 'Contact No.', A.customerNIC AS 'Customer NIC', A.vehicleRegNum AS 'Vehical Number', A.fromDate AS 'Starting Date', A.toDate AS 'End Date', A.advancePayment AS 'Advanced Payment', A.driverNIC AS 'Driver NIC' FROM rent A, customer B WHERE A.customerNIC=B.NIC AND A.rentType = 'Reserved'; ";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                                                   // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //MySqlConnection con = new MySqlConnection("user id = root; server = localhost; database = carrent; port = 3306;");
            //MySqlCommand cm = new MySqlCommand("SELECT * FROM `rent`", con);
            //MySqlDataAdapter da = new MySqlDataAdapter(cm);
            //DataTable dt = new DataTable();
            //da.Fill(dt);

            //dataGridView1.DataSource = dt;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            txt_resName.Text = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            txt_resNIC.Text = dataGridView1.Rows[e.RowIndex].Cells["Customer NIC"].Value.ToString();
            txt_resCNo.Text = dataGridView1.Rows[e.RowIndex].Cells["Contact No."].Value.ToString();
            txt_resAdpay.Text = dataGridView1.Rows[e.RowIndex].Cells["Advanced Payment"].Value.ToString();
            txt_resVID.Text = dataGridView1.Rows[e.RowIndex].Cells["Vehical Number"].Value.ToString();
            dtp_start.Text = dataGridView1.Rows[e.RowIndex].Cells["Starting Date"].Value.ToString();
            dtp_end.Text = dataGridView1.Rows[e.RowIndex].Cells["End Date"].Value.ToString();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_ReleaseVehicle_Click(object sender, EventArgs e)
        {
           /* Invoice reserveInvoice = new Invoice();
            reserveInvoice.cusName = txt_resName.Text;
            reserveInvoice.cusNIC = txt_resNIC.Text;
            reserveInvoice.cusCNo = txt_resCNo.Text;
            reserveInvoice.cusAdPay = txt_resAdpay.Text;
            reserveInvoice.vehicleID = txt_resVID.Text;
            reserveInvoice.startMileage = txt_resSM.Text;
            reserveInvoice.startDate = dtp_start.Text;
            reserveInvoice.endDate = dtp_end.Text;
            reserveInvoice.ShowDialog();*/
        }
    }
}
