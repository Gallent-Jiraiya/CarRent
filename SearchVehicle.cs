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
    public partial class SearchVehicle : UserControl
    {
        public SearchVehicle()
        {
            InitializeComponent();
            
        }
        #region Properties

        private String _year;
        private String _picture;
        private int _price;
        private String _mileage;
        private int _perKm;
        private String _ac;
        private String _model;
        private String _passengers;
        private String _transmission;
        private String _luggage;
        private String _regNo;
        private int _days;

        private DateTime _startDay=DateTime.Now;

        public DateTime StartDay
        {
            get { return _startDay; }
            set { _startDay = value; }
        }

        private DateTime _endDay=DateTime.Now;

        public DateTime EndDay
        {
            get { return _endDay; }
            set { _endDay = value; }
        }


        public String RegNo
        {
            get { return _regNo; }
            set { _regNo = value; Lbl_RegNo.Text = "Reg. Num: " + value; }
        }

        public String Year
        {
            get { return _year; }
            set { _year = value; Lbl_Year.Text = "Model Year: " + value; }
        }


        [Category("Custom Props")]
        public String Picture
        {
            get { return _picture; }
            set { _picture = value; PB_VehicleImage.Image = Image.FromFile(@"../../Images/Vehicles/" + value); }
        }

        public int Days
        {
            get { return _days; }
            set { _days = value;
                Lbl_Price.Text = "LKR " + (_price * _days);
                Lbl_Cal.Text = "LKR " + _price + " X " + _days;
            }
        }


        [Category("Custom Props")]
        public int Price
        {
            get { return _price; }
            set { _price = value; 
                
            }
        }

        


        [Category("Custom Props")]
        public String Mileage
        {
            get { return _mileage; }
            set { _mileage = value; Lbl_Milage.Text = "Free Mileage: " + value; }
        }



        [Category("Custom Props")]
        public int PerKm
        {
            get { return _perKm; }
            set { _perKm = value; Lbl_PerKM.Text = value + " Per Extra Km"; }
        }



        [Category("Custom Props")]
        public String AC
        {
            get { return _ac; }
            set { _ac = value; Lbl_AC.Text = value + " Air Condition"; }
        }




        [Category("Custom Props")]
        public String Model
        {
            get { return _model; }
            set { _model = value; Lbl_BrandName.Text = value; }
        }


        [Category("Custom Props")]
        public String Passengers
        {
            get { return _passengers; }
            set { _passengers = value; Lbl_NoPassenger.Text = value + " Passenger"; }
        }


        [Category("Custom Props")]
        public String Transmission
        {
            get { return _transmission; }
            set { _transmission = value; Lbl_Transmission.Text = value + "Transmission"; }
        }



        [Category("Custom Props")]
        public String Luggage
        {
            get { return _luggage; }
            set { _luggage = value; Lbl_Luggages.Text = value + " Luggages"; }
        }

        #endregion

        private void Btn_Book_Click(object sender, EventArgs e)
        {
            var bookNowForm = new Book_Now();
            bookNowForm.Price = _price;
            bookNowForm.RegNo = _regNo;
            bookNowForm.Days = _days;
            bookNowForm.StartDate = _startDay;
            bookNowForm.EndDate = _endDay;
            bookNowForm.DriverCombo();
            bookNowForm.Show();
        }
    }
}
