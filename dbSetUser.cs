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
        string sql_query;


        public void userInsert_value(string fName, string lName, string nic, string address, string email, string mobile, string userName, string pw)
        {
            sql_query = "INSERT into staff (NIC,userName,fName,lName,contactNo,address,email,password) values('" + nic + "','" + userName + "','" + fName + "','" + lName + "','" + mobile + "','" + address + "','" + email + "','" + pw + "')";
            try
            {
                MySqlConnection con = new DbConnection().getDb;

                MySqlCommand myCommand = new MySqlCommand(sql_query, con);
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


    }
}
