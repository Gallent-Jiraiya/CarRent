using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

