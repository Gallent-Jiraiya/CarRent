using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CarRent
{
    public class DbConnection
    {

        MySqlConnection connection = new MySqlConnection("user id=root;server=localhost;database=carrent;port=3307;");
        public MySqlConnection getDb
        {
            get { return connection; }

        }


    }
    


}
