using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace airport
{
    public static class ConnectionDB
    {
        public static SqlConnection sqlcon;
        public static void Open()
        {
            sqlcon = new SqlConnection("Server = 192.168.0.6; Database=edu2; uid = edu2; pwd = edukornec!@#");
            SqlCommand comm = new SqlCommand();
            sqlcon.Open();
        }

        public static void Close()
        {
            if (sqlcon.State == System.Data.ConnectionState.Open)
            {
                sqlcon.Close();
            }
        }


    }



}
