using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Conexion
    {
        public static SqlConnection conectar()
        {
          SqlConnection cn = new SqlConnection("SERVER=DESKTOP-K6LB0LV\\SQLEXPRESS; DATABASE=BomberosVoluntarios;integrated security=true;");
            cn.Open();
            return cn;
        }
    }
}
