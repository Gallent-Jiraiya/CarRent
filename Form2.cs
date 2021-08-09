using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace CarRent
{
    public partial class Form2 : Form
    {
        MySqlCommand command;
        HashCode hc = new HashCode();

        public Form2() => InitializeComponent();

        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=carrent");

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           // con.Open();
            String username = txt_user.Text;
            String password = hc.passHash(txt_pass.Text);

            String queary = $" Select * FROM staff where userName='{username}' ";
            try
            {
                con.Open();
                command = new MySqlCommand(queary, con);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    String Password = reader.GetString(7);

                    if (password.Equals(Password))
                    {

                        MessageBox.Show("Login Sucsses");
                        Ureference usr = new Ureference()
                        {
                            User = txt_user.Text
                        };

                        Form1 frm1 = new Form1();
                        frm1.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Password is incorrect");
                    }

                }
                else
                {
                    MessageBox.Show("Please enter the valid credentials");

                }
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




            /*  string Password = "";
              bool IsExist = false;
              string UserName = txt_user.Text;

              con.Open();
              MySqlCommand cmd = new MySqlCommand($"select * from staff where userName='{UserName}'", con);
              MySqlDataReader sdr = cmd.ExecuteReader();
              if (sdr.Read())
              {
                  Password = sdr.GetString(7);  //get the user password from db if the user name is exist in that.  
                  IsExist = true;
              }
              con.Close();
              if (IsExist)  //if record exis in db , it will return true, otherwise it will return false  
              {
                  if (Cryptography.Decrypt(Password).Equals(txt_pass.Text))
                  {
                      MessageBox.Show("Login Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      Form1 frm1 = new Form1();
                      frm1.ShowDialog();
                  }
                  else
                  {
                      MessageBox.Show("Password is wrong!...", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  }

              }
              else  //showing the error message if user credential is wrong  
              {
                  MessageBox.Show("Please enter the valid credentials", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
              } */

        }

       
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_user.Text = string.Empty;
            txt_pass.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
