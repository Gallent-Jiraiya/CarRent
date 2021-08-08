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
    public partial class Form1 : Form
    {
         static Form1 _obj;

        public static Form1 GetInstance()
        {
            if (_obj == null)
            {
                _obj = new Form1();
            }
            return _obj;
        }


        public Panel PnlContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }

        public RadioButton DashboardButton
        {
            get { return dashboardButton; }
            set { dashboardButton = value; }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            System.Environment.Exit(1);
            /*int count = deleteVehicleImage.names.Count;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(deleteVehicleImage.names[i]);
                if (System.IO.File.Exists("../../Images/Vehicles/" + deleteVehicleImage.names[i]))
                {
                    System.IO.File.Delete("../../Images/Vehicles/" + deleteVehicleImage.names[i]);

                }
            }
            deleteVehicleImage.names.Clear();*/
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            panelContainer.Controls["US_Dashboard"].BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _obj = this;
            US_Dashboard ucDash = new US_Dashboard();
            ucDash.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(ucDash);
            US_Search ucSrch = new US_Search();
            ucSrch.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(ucSrch);
            US_OnRent ucOnrent = new US_OnRent();
            ucOnrent.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(ucOnrent);
            US_Reserved ucReserve = new US_Reserved();
            ucReserve.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(ucReserve);
            US_Users ucUsers = new US_Users();
            ucUsers.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(ucUsers);
            US_Vehicles ucVehicles = new US_Vehicles();
            ucVehicles.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(ucVehicles);


        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            
            panelContainer.Controls["US_Search"].BringToFront();
        }

        private void onrentButton_Click(object sender, EventArgs e)
        {
            
            panelContainer.Controls["US_OnRent"].BringToFront();
        }

        private void reservedButton_Click(object sender, EventArgs e)
        {
            
            panelContainer.Controls["US_Reserved"].BringToFront();
        }

        private void usersButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void usersButton_Click(object sender, EventArgs e)
        {
            
            panelContainer.Controls["US_Users"].BringToFront();
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vehiclesButton_Click(object sender, EventArgs e)
        {
            
            panelContainer.Controls["US_Vehicles"].BringToFront();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
