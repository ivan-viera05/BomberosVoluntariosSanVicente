using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato
{
    public class DatosVehiculos
    {

        public DataTable ObtenerVehiculos()
        {
           
                string sql = "SELECT * FROM VehiculosBomberos";
                using (SqlCommand cmd = new SqlCommand(sql, Conexion.conectar()))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            
        }
    }
}
