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
    public partial class AddEmployees_Users : Form
    {
        public AddEmployees_Users()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text == "")
            {
                MessageBox.Show("Please enter the first name", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (guna2TextBox2.Text == "")
            {
                MessageBox.Show("Please enter the last name", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (guna2TextBox3.Text == "")
            {
                MessageBox.Show("Please enter the NIC number", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (guna2TextBox4.Text == "")
            {
                MessageBox.Show("Please enter the address", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (guna2TextBox5.Text == "")
            {
                MessageBox.Show("Please enter the email address", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (guna2TextBox8.Text == "")
            {
                MessageBox.Show("Please enter the mobile number", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (guna2TextBox6.Text == "")
            {
                MessageBox.Show("Please enter the username", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (guna2TextBox7.Text == "")
            {
                MessageBox.Show("Please enter the password", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBox1.Text != "Admin" && comboBox1.Text != "Staff")
            {
                MessageBox.Show("Please select a type", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if (guna2TextBox3.Text.Length == 10 || guna2TextBox3.Text.Length == 11)
                {
                    dbSetUser add = new dbSetUser();
                    add.userInsert_value(guna2TextBox1.Text, guna2TextBox2.Text, guna2TextBox3.Text, guna2TextBox4.Text, guna2TextBox5.Text, guna2TextBox8.Text, guna2TextBox6.Text, guna2TextBox7.Text, comboBox1.Text);
                }
                else
                {
                    MessageBox.Show("Please enter a valid NIC number", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void Clear()
        {
            guna2TextBox1.Text = "";
            guna2TextBox2.Text = "";
            guna2TextBox3.Text = "";
            guna2TextBox4.Text = "";
            guna2TextBox5.Text = "";
            guna2TextBox6.Text = "";
            guna2TextBox7.Text = "";
            guna2TextBox8.Text = "";
            comboBox1.Text = "";
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
