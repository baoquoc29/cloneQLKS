using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hotel_Management_System_Winforrm
{
    class Connection
    {
        private static string connection = @"Data Source=LAPTOP-9N17HVBV\SQLEXPRESS01;Initial Catalog=QLKS;Integrated Security=True";
    
        public static SqlConnection getConnection()
        {
            return new SqlConnection(connection);
        }

    }
}
