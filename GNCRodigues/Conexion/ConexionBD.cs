using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GNCRodigues.Conexion
{
    public class ConexionBD
    {
        public static SqlConnection Obtenerconexion()
        {
            SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-417K253;Initial Catalog=GNCRodrigues;Integrated Security=True");
            conexion.Open();

            return conexion;

        } 
        
    }
}
