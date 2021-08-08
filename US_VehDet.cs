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
    public partial class US_VehDet : UserControl
    {
        public US_VehDet()
        {
            InitializeComponent();
        }
        private string picPath;
        private string oldpicture;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnImg = new OpenFileDialog();
            opnImg.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;*.png;)|*.jpg;*.jpeg;.*.gif;*.png;";
            if (opnImg.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(opnImg.FileName);
                picPath = opnImg.FileName;
                oldpicture = _picture;
                deleteVehicleImage.names.Add(oldpicture);

            }
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
            set { _picture = value; pictureBox1.Image = Image.FromFile("../../Images/Vehicles/"+value); }
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            Cmb_Luggage.Text = "";
            passenger.Text = "";
            PricePerKM.Text = "";
            ModelYear.Text = ""; 
            ModelVeh.Text = ""; 
            Regno.Text = ""; 
            RentingPrice.Text = ""; 
            FreeMileage.Text = "";
            pictureBox1.Image = null;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            
            MySqlConnection con = new DbConnection().getDb;
            con.Open();
            if (Rad_Full.Checked == true )
            {

                _ac = "Full";
            }
            else
            {
                _ac = "No";
            }

            if (Rad_Auto.Checked == true)
            {
                _transmission = "Auto";
            }
            else
            {
                _transmission = "Manual";
            }
            _perKm = PricePerKM.Text;
            _luggage=Cmb_Luggage.Text ;
            _passengers= passenger.Text;
            _year= ModelYear.Text;
            _model= ModelVeh.Text;
            _regNo=Regno.Text;
            _price= RentingPrice.Text ;
            _mileage= FreeMileage.Text ;
            Bitmap bm;
            if (picPath == null)
            {
                 bm= Image.FromFile("../../Images/Vehicles/" + _picture) as Bitmap;
            }
            else
            {
                 bm = Image.FromFile(picPath) as Bitmap;
            }
            _picture = _model + _year + _regNo + ".png";
            

            try { 
                string Query = "insert into vehicle(regNum,brand,picture,pricePerDay,freeMilage,pricePerExtraKM,transmissionType,airCondition,Luggage,modelYear,passengers) values('" +_regNo + "','" + _model + "','" + _picture + "','" +_price + "','" + _mileage+ "','" + _perKm + "','" + _transmission+ "','" + _ac + "','" + _luggage + "','" + _year + "','" + _passengers + "');";
                MySqlCommand cmd = new MySqlCommand(Query, con);
                MySqlDataReader MyReader2;
                MyReader2 = cmd.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Save Data");
                bm.Save("../../Images/Vehicles/" + _picture);

                while (MyReader2.Read())
                {
                }
            
                
            }  
            catch (Exception ex)  
            {   
                MessageBox.Show(ex.Message);  
            }

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new DbConnection().getDb;
            con.Open();
            if (Rad_Full.Checked == true)
            {

                _ac = "Full";
            }
            else
            {
                _ac = "No";
            }

            if (Rad_Auto.Checked == true)
            {
                _transmission = "Auto";
            }
            else
            {
                _transmission = "Manual";
            }
            string _oldRegNo = _regNo;
            _perKm = PricePerKM.Text;
            _luggage = Cmb_Luggage.Text;
            _passengers = passenger.Text;
            _year = ModelYear.Text;
            _model = ModelVeh.Text;
            _regNo = Regno.Text;
            _price = RentingPrice.Text;
            _mileage = FreeMileage.Text;
            
            if (picPath != null) {
                _picture = _model + _year + _regNo + ".png";
                int i = 0;
                while (System.IO.File.Exists("../../Images/Vehicles/" + _picture))
                {
                    _picture = _model + _year + _regNo + i + ".png";
                    i++;
                }
               
                Bitmap bm = Image.FromFile(picPath) as Bitmap;
                //System.IO.File.Delete("../../Images/Vehicles/" + oldpicture);
                bm.Save("../../Images/Vehicles/" + _picture);

            }
            else
            {
                Bitmap bm = Image.FromFile("../../Images/Vehicles/"+_picture) as Bitmap;
                //System.IO.File.Delete("../../Images/Vehicles/" + oldpicture);
                _picture = _model + _year + _regNo + ".png";
                bm.Save("../../Images/Vehicles/" + _picture);
            }

            try
            {
                string Query = "update vehicle set regNum='" + _regNo + "',brand='" + _model + "',picture='" + _picture + "',pricePerDay='" + _price + "',freeMilage='" + _mileage + "',pricePerExtraKM='" + _perKm+ "',transmissionType='" + _transmission + "',airCondition='" + _ac + "',Luggage='" + _luggage+ "',modelYear='" + _year + "',passengers='" + _passengers + "' where regNum='" + _oldRegNo + "';";
                //string Query = "insert into vehicle(regNum,brand,picture,pricePerDay,freeMilage,pricePerExtraKM,transmissionType,airCondition,Luggage,modelYear,passengers) values('" + _regNo + "','" + _model + "','" + _picture + "','" + _price + "','" + _mileage + "','" + _perKm + "','" + _transmission + "','" + _ac + "','" + _luggage + "','" + _year + "','" + _passengers + "');";
                MySqlCommand cmd = new MySqlCommand(Query, con);
                MySqlDataReader MyReader2;
                MyReader2 = cmd.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Save Data");
                while (MyReader2.Read())
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Cmb_Luggage.Text = "";
            passenger.Text = "";
            PricePerKM.Text = "";
            ModelYear.Text = ""; 
            ModelVeh.Text = ""; 
            Regno.Text = ""; 
            RentingPrice.Text = ""; 
            FreeMileage.Text = "";
            pictureBox1.Image = null;
            try
            {
                MySqlConnection con = new DbConnection().getDb;
                con.Open();
                string Query = "delete from vehicle where regNum='" + _regNo + "';";
                //string Query = "insert into vehicle(regNum,brand,picture,pricePerDay,freeMilage,pricePerExtraKM,transmissionType,airCondition,Luggage,modelYear,passengers) values('" + _regNo + "','" + _model + "','" + _picture + "','" + _price + "','" + _mileage + "','" + _perKm + "','" + _transmission + "','" + _ac + "','" + _luggage + "','" + _year + "','" + _passengers + "');";
                MySqlCommand cmd = new MySqlCommand(Query, con);
                MySqlDataReader MyReader2;
                MyReader2 = cmd.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Data Deleted");
                deleteVehicleImage.names.Add(_picture);
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
