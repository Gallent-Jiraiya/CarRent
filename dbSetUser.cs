using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace CarRent
{
    class dbSetUser
    {
        string sql_query1;
        string sql_query2;


        public void userInsert_value(string fName, string lName, string nic, string address, string email, string mobile, string userName, string pw, string type)
        {
            HashCode hc = new HashCode();
            String password = hc.passHash(pw);
            sql_query1 = "INSERT into staff (NIC,userName,fName,lName,contactNo,address,email,password,type,picture) values('" + nic + "','" + userName + "','" + fName + "','" + lName + "','" + mobile + "','" + address + "','" + email + "','" + password + "','" + type + "','images.jpg')";
            try
            {
                MySqlConnection con = new DbConnection().getDb;

                MySqlCommand myCommand = new MySqlCommand(sql_query1, con);
                MySqlDataReader MyReader2;
                con.Open();
                MyReader2 = myCommand.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Data Saved");
                while (MyReader2.Read())
                {
                }
                con.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void userUpdate_value(string userName, string pw)
        {
            HashCode hc = new HashCode();
            String password = hc.passHash(pw);
            Ureference usr = new Ureference();
            sql_query2 = "UPDATE staff SEt userName='" + userName + "',password='" + password + "' where userName='" + usr.User+"'";
            try
            {
                MySqlConnection con = new DbConnection().getDb;

                MySqlCommand myCommand = new MySqlCommand(sql_query2, con);
                MySqlDataReader MyReader2;
                con.Open();
                MyReader2 = myCommand.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Data Updated");
                while (MyReader2.Read())
                {
                }
                con.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void userUpdate_value(string userName, string pw,String pic)
        {
            HashCode hc = new HashCode();
            String password = hc.passHash(pw);
            Ureference usr = new Ureference();
            sql_query2 = "UPDATE staff SEt userName='" + userName + "',password='" + password + "',picture='"+pic+"' where userName='" + usr.User + "'";
            try
            {
                MySqlConnection con = new DbConnection().getDb;

                MySqlCommand myCommand = new MySqlCommand(sql_query2, con);
                MySqlDataReader MyReader2;
                con.Open();
                MyReader2 = myCommand.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Data Updated");
                while (MyReader2.Read())
                {
                }
                con.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
