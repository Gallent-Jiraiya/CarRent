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
    public partial class US_Users : UserControl
    {
        public US_Users()
        {
            InitializeComponent();
            userData();
        }
        private void userData()
        {
            try
            {
                Ureference usr = new Ureference();
                MySqlConnection con = new DbConnection().getDb;
                con.Open();
                String Query = "SELECT * from staff WHERE userName='"+usr.User+"'";
                MySqlCommand cmd = new MySqlCommand(Query, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                
                while (dr.Read()) 
                { 
                    lbl_UserName.Text= dr.GetString("fName");
                    lbl_User.Text= dr.GetString("userName");
                    roundPictureBox1.Image = new Bitmap("../../Images/Users/" + dr.GetString("picture"));
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

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            var addEmpoyeeForm = new AddEmployees_Users();
            addEmpoyeeForm.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var editProfleForm = new editProfile_Users();
            editProfleForm.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            var removeEmployeesForm = new removeEmployee_Users();
            removeEmployeesForm.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            var editDriversForm = new editDrivers_Users();
            editDriversForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}

