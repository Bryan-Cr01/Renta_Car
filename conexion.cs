using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Renta_Car
{
    class conexion
    {
        public static SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection("SERVER=LAPTOP-2156K7P6 SQLEXPRESS;DATABASE= renta_car; Integrated security= true");
            cn.Open();
            return cn;
        }
    }
}
