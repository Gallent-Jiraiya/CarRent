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
    public partial class editProfile_Users : Form
    {
        public editProfile_Users()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter the username", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Please enter the new password", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Please re-enter the password", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Please re-enter the password correctly", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("Please enter the old password", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
              /*   if (textBox4.Text == staff.password)
                 {
                     dbSetUser add = new dbSetUser();
                     add.userUpdate_value(textBox1.Text, textBox2.Text);
                 }
                 else
                 {
                     MessageBox.Show("Please enter the correct old password", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }*/
            }
        }
    }
}
