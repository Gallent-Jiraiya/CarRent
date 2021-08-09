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
    public partial class editDrivers_Users : Form
    {
        public editDrivers_Users()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void editDrivers_Users_Load(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "datasource= localhost; database=carrent; port=3306; username = root;";
                //Display query  
                string Query = "SELECT CONCAT(fName, ' ' ,lName) AS 'Name', NIC AS 'NIC', d_Licence AS 'Licence', age AS 'Age', contactNo AS 'Contact No.', address AS 'Address' FROM driver";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                DataGridViewDriver.DataSource = dTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private String _oldNIC;

        private void DataGridViewDriver_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewDriver.CurrentRow.Selected = true;
            txtD_name.Text = DataGridViewDriver.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            txtD_NIC.Text = DataGridViewDriver.Rows[e.RowIndex].Cells["NIC"].Value.ToString();
            txtD_License.Text = DataGridViewDriver.Rows[e.RowIndex].Cells["Licence"].Value.ToString();
            txtD_Age.Text = DataGridViewDriver.Rows[e.RowIndex].Cells["Age"].Value.ToString();
            txtD_CNo.Text = DataGridViewDriver.Rows[e.RowIndex].Cells["Contact No."].Value.ToString();
            txtD_Address.Text = DataGridViewDriver.Rows[e.RowIndex].Cells["Address"].Value.ToString();

            _oldNIC = DataGridViewDriver.Rows[e.RowIndex].Cells["NIC"].Value.ToString();

        }

        private void btn_dAdd_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new DbConnection().getDb;
            con.Open();

            String _dName = txtD_name.Text;
            String _dNIC = txtD_NIC.Text;
            String _dLicence = txtD_License.Text;
            String _dAge = txtD_Age.Text;
            String _dCNo = txtD_CNo.Text;
            String _dAddress = txtD_Address.Text;


            try
            {
                string Query = "insert into driver(fName, NIC, d_Licence, age, contactNo, address) values('" + _dName + "','" + _dNIC + "','" + _dLicence + "','" + _dAge + "','" + _dCNo + "','" + _dAddress + "');";
                MySqlCommand cmd = new MySqlCommand(Query, con);
                MySqlDataReader MyReader2;
                MyReader2 = cmd.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Save Data");

                while (MyReader2.Read())
                {
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                string MyConnection2 = "datasource= localhost; database=carrent; port=3306; username = root;";
                //Display query  
                string Query = "SELECT CONCAT(fName, ' ' ,lName) AS 'Name', NIC AS 'NIC', d_Licence AS 'Licence', age AS 'Age', contactNo AS 'Contact No.', address AS 'Address' FROM driver";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                DataGridViewDriver.DataSource = dTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_dUpdate_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new DbConnection().getDb;
            con.Open();

           
            String _dName = txtD_name.Text;
            String _dNIC = txtD_NIC.Text;
            String _dLicence = txtD_License.Text;
            String _dAge = txtD_Age.Text;
            String _dCNo = txtD_CNo.Text;
            String _dAddress = txtD_Address.Text;

            try
            {
                string Query = "update driver set fName='" + _dName + "',NIC='" + _dNIC + "',d_Licence='" + _dLicence + "',age='" + _dAge + "',contactNo='" + _dCNo + "',address='" + _dAddress + "' where NIC='" + _oldNIC + "';";
                MySqlCommand cmd = new MySqlCommand(Query, con);
                MySqlDataReader MyReader2;
                MyReader2 = cmd.ExecuteReader();
                MessageBox.Show("Save Data");
                while (MyReader2.Read())
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                string MyConnection2 = "datasource= localhost; database=carrent; port=3306; username = root;";
                //Display query  
                string Query = "SELECT CONCAT(fName, ' ' ,lName) AS 'Name', NIC AS 'NIC', d_Licence AS 'Licence', age AS 'Age', contactNo AS 'Contact No.', address AS 'Address' FROM driver";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                DataGridViewDriver.DataSource = dTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_dRemove_Click(object sender, EventArgs e)
        {
            txtD_name.Text = "";
            txtD_NIC.Text = "";
            txtD_License.Text = "";
            txtD_Age.Text = "";
            txtD_CNo.Text = "";
            txtD_Address.Text = "";

            try
            {
                MySqlConnection con = new DbConnection().getDb;
                con.Open();
                string Query = "delete from driver where NIC='" + _oldNIC + "';";
                MySqlCommand cmd = new MySqlCommand(Query, con);
                MySqlDataReader MyReader2;
                MyReader2 = cmd.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Data Deleted");
                while (MyReader2.Read())
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                string MyConnection2 = "datasource= localhost; database=carrent; port=3306; username = root;";
                //Display query  
                string Query = "SELECT CONCAT(fName, ' ' ,lName) AS 'Name', NIC AS 'NIC', d_Licence AS 'Licence', age AS 'Age', contactNo AS 'Contact No.', address AS 'Address' FROM driver";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                DataGridViewDriver.DataSource = dTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
