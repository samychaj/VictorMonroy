using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Roles.Clases
{
    public class Conexion
    {
        SqlConnection conn = new SqlConnection();
        public SqlConnection Openn()
        {
            conn.ConnectionString = "Data Source=localhost;Initial Catalog=prueba;Persist Security Info=True;User ID=sa;Password=<prueba20>";
            try
            {
                conn.Open();
            }
            catch(Exception e)
            {
                conn.Close();
            }
            return conn;
        }

        public void Closee()
        {
            conn.Close();
        }
    }
}