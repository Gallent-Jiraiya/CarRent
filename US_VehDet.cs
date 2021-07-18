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
    public partial class US_VehDet : UserControl
    {
        public US_VehDet()
        {
            InitializeComponent();
        }
        private String imgLoc;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnImg = new OpenFileDialog();
            opnImg.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;*.png;)|*.jpg;*.jpeg;.*.gif;*.png;";
            if (opnImg.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(opnImg.FileName);
                imgLoc = opnImg.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string folder = @"Images\Vehicles\";
            var path = Path.Combine(folder, Path.GetFileName(imgLoc));
            if (!Directory.Exists(folder))
            {

                Directory.CreateDirectory(folder);
            }
            File.Copy(imgLoc, path, true);
        }

        #region Properties
        private String _regNo;

        public String RegNo
        {
            get { return _regNo; }
            set { _regNo = value; Regno.Text = value; }
        }

        private String _year;

        public String Year
        {
            get { return _year; }
            set { _year = value; ModelYear.Text = value; }
        }

        private String _picture;

        [Category("Custom Props")]
        public String Picture
        {
            get { return _picture; }
            set { _picture = value; pictureBox1.Image = Image.FromFile(value); }
        }


        private String _price;

        [Category("Custom Props")]
        public String Price
        {
            get { return _price; }
            set { _price = value; RentingPrice.Text = value; }
        }

        private String _mileage;

        [Category("Custom Props")]
        public String Mileage
        {
            get { return _mileage; }
            set { _mileage = value; FreeMileage.Text = value; }
        }

        private String _perKm;

        [Category("Custom Props")]
        public String PerKm
        {
            get { return _perKm; }
            set { _perKm = value; PricePerKM.Text = value; }
        }

        private String _ac;

        [Category("Custom Props")]
        public String AC
        {
            get { return _ac; }
            set
            {
                _ac = value;
                if (value == "Full")
                {
                    Rad_Full.Checked = true;
                    Rad_NoAir.Checked = false;
                }
                else
                {
                    Rad_NoAir.Checked = true;
                    Rad_Full.Checked = false;
                }
            }
        }


        private String _model;

        [Category("Custom Props")]
        public String Model
        {
            get { return _model; }
            set { _model = value; ModelVeh.Text = value; }
        }
        private String _passengers;

        [Category("Custom Props")]
        public String Passengers
        {
            get { return _passengers; }
            set { _passengers = value; passenger.Text = value; }
        }
        private String _transmission;

        [Category("Custom Props")]
        public String Transmission
        {
            get { return _transmission; }
            set
            {
                _transmission = value;
                if (value == "Auto")
                {
                    Rad_Auto.Checked = true;
                    Rad_Manual.Checked = false;
                }
                else
                {
                    Rad_Manual.Checked = true;
                    Rad_Auto.Checked = false;
                }
            }
        }

        private String _luggage;

        [Category("Custom Props")]
        public String Luggage
        {
            get { return _luggage; }
            set { _luggage = value; Cmb_Luggage.Text = value; }
        }
        #endregion

        private void Passenger_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Rad_Full_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Rad_NoAir_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Rad_Manual_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Rad_Auto_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Cmb_Luggage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ModelYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FreeMileage_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void PricePerKM_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void RentingPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void ModelVeh_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
