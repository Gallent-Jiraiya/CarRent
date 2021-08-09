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
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CarRent
{
    public partial class editProfile_Users : Form
    {
        public editProfile_Users()
        {
            InitializeComponent();
            userData();
        }
        private string picPath=null;
        private string oldpicture;
        String _picture;
        private void userData()
        {
            try
            {
                Ureference usr = new Ureference();
                MySqlConnection con = new DbConnection().getDb;
                con.Open();
                String Query = "SELECT * from staff WHERE userName='" + usr.User + "'";
                MySqlCommand cmd = new MySqlCommand(Query, con);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    txt_UserName.Text = dr.GetString("userName");
                    guna2PictureBox1.Image = new Bitmap("../../Images/Users/" + dr.GetString("picture"));
                    _picture= dr.GetString("picture");
                    
                }
            }
            catch (IOException e)
            {
                // Extract some information from this exception, and then
                // throw it to the parent method.
                if (e.Source != null)
                    Console.WriteLine("IOException source: {0}", e.Source);
                throw;
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txt_UserName.Text == "")
            {
                MessageBox.Show("Please enter the username", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Txt_NewPass.Text == "")
            {
                MessageBox.Show("Please enter the new password", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_ReNewPass.Text == "")
            {
                MessageBox.Show("Please re-enter the password", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Txt_NewPass.Text != txt_ReNewPass.Text)
            {
                MessageBox.Show("Please re-enter the password correctly", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_OldPass.Text == "")
            {
                MessageBox.Show("Please enter the old password", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (picPath != null)
                {
                    _picture = txt_UserName.Text + ".png";
                    int i = 0;
                    while (System.IO.File.Exists("../../Images/Users/" + _picture))
                    {
                        _picture = txt_UserName.Text + i + ".png";
                        i++;
                    }

                    Bitmap bm = Image.FromFile(picPath) as Bitmap;
                    bm.Save("../../Images/Users/" + _picture);
                    string oldpass = "";
                    HashCode hc = new HashCode();
                    String oldpassword = hc.passHash(txt_OldPass.Text);
                    try
                    {
                        Ureference usr = new Ureference();
                        MySqlConnection con = new DbConnection().getDb;
                        con.Open();
                        String Query = "SELECT * from staff WHERE userName='" + usr.User + "'";
                        MySqlCommand cmd = new MySqlCommand(Query, con);
                        MySqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            oldpass = dr.GetString("password");
                        }
                    }
                    catch (IOException ex)
                    {
                        // Extract some information from this exception, and then
                        // throw it to the parent method.
                        if (ex.Source != null)
                            Console.WriteLine("IOException source: {0}", ex.Source);
                        throw;
                    }
                    if (oldpassword == oldpass)
                    {
                        dbSetUser add = new dbSetUser();
                        add.userUpdate_value(txt_UserName.Text, Txt_NewPass.Text,_picture);
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Please enter the correct old password", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    string oldpass = "";
                    HashCode hc = new HashCode();
                    String oldpassword = hc.passHash(txt_OldPass.Text);
                    try
                    {
                        Ureference usr = new Ureference();
                        MySqlConnection con = new DbConnection().getDb;
                        con.Open();
                        String Query = "SELECT * from staff WHERE userName='" + usr.User + "'";
                        MySqlCommand cmd = new MySqlCommand(Query, con);
                        MySqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            oldpass = dr.GetString("password");
                        }
                    }
                    catch (IOException ex)
                    {
                        // Extract some information from this exception, and then
                        // throw it to the parent method.
                        if (ex.Source != null)
                            Console.WriteLine("IOException source: {0}", ex.Source);
                        throw;
                    }
                    if (oldpassword == oldpass)
                    {
                        dbSetUser add = new dbSetUser();
                        add.userUpdate_value(txt_UserName.Text, Txt_NewPass.Text);
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Please enter the correct old password", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
               
            }
        }
        
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnImg = new OpenFileDialog();
            opnImg.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;*.png;)|*.jpg;*.jpeg;.*.gif;*.png;";
            if (opnImg.ShowDialog() == DialogResult.OK)
            {
                guna2PictureBox1.Image = new Bitmap(opnImg.FileName);
                picPath = opnImg.FileName;
                oldpicture = _picture;
                deleteVehicleImage.names.Add(oldpicture);

            }
        }
    }
}
