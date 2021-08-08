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

        private void DataGridViewDriver_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewDriver.CurrentRow.Selected = true;
            txtD_name.Text = DataGridViewDriver.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            txtD_NIC.Text = DataGridViewDriver.Rows[e.RowIndex].Cells["NIC"].Value.ToString();
            txtD_License.Text = DataGridViewDriver.Rows[e.RowIndex].Cells["Licence"].Value.ToString();
            txtD_Age.Text = DataGridViewDriver.Rows[e.RowIndex].Cells["Age"].Value.ToString();
            txtD_CNo.Text = DataGridViewDriver.Rows[e.RowIndex].Cells["Contact No."].Value.ToString();
            txtD_Address.Text = DataGridViewDriver.Rows[e.RowIndex].Cells["Address"].Value.ToString();
     
        }
    }
}
