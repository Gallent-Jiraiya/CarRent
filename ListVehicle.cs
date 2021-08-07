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
    public partial class ListVehicle : UserControl
    {
        public ListVehicle()
        {
            InitializeComponent();
        }
        #region Properties

        private String _year;
        private String _picture;
        private String _price;
        private String _mileage;
        private String _perKm;
        private String _ac;
        private String _model;
        private String _passengers;
        private String _transmission;
        private String _luggage;
        private String _regNo;

        public String RegNo
        {
            get { return _regNo; }
            set { _regNo = value; }
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
            set { _picture = value; PB_VehicleImage.Image = Image.FromFile(@"../../Images/Vehicles/"+value); }
        }


       

        [Category("Custom Props")]
        public String Price
        {
            get { return _price; }
            set { _price = value; Lbl_Price.Text = "LKR " + value; }
        }

        

        [Category("Custom Props")]
        public String Mileage
        {
            get { return _mileage; }
            set { _mileage = value; Lbl_Milage.Text = "Free Mileage: " + value; }
        }

        

        [Category("Custom Props")]
        public String PerKm
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

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            US_VehDet item = new US_VehDet();
            
            item.Picture =_picture;
            item.Year = _year;
            item.AC = _ac;
            item.Transmission = _transmission;
            item.Price = _price;
            item.Mileage = _mileage;
            item.PerKm = _perKm;
            item.Model = _model;
            item.Luggage = _luggage;
            item.Passengers = _passengers;
            item.RegNo = _regNo;
            
            
            US_Vehicles veh = new US_Vehicles();
            veh.editPanel(item);
            this.Parent.Parent.Controls.Add(veh);
            this.Parent.Parent.Controls.RemoveAt(2);


        }
    }
}
