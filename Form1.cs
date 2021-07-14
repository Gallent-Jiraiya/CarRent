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
        public static Form1 Instance
        {
            get
            {
                if(_obj == null)
                {
                    _obj = new Form1();
                }
                return _obj;
            }
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
            System.Windows.Forms.Application.Exit();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            panelContainer.Controls["US_Dashboard"].BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _obj = this;
            US_Dashboard uc = new US_Dashboard();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            US_Search ucSrch = new US_Search();
            ucSrch.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(ucSrch);
            panelContainer.Controls["US_Search"].BringToFront();
        }

        private void onrentButton_Click(object sender, EventArgs e)
        {
            US_ ucSrch = new US_Search();
            ucSrch.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(ucSrch);
            panelContainer.Controls["US_Search"].BringToFront();
        }
    }
}
