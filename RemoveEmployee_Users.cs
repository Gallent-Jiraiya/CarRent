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
    public partial class removeEmployee_Users: Form
    {
        public removeEmployee_Users()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
          
            try
            {
                MySqlConnection con = new DbConnection().getDb;
                con.Open();
                string Query = "delete from staff where NIC='" + txt_EmpNIC.Text + "';";
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
        }
    }
}
