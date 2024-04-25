using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GNCRodigues.Conexion
{
     class PruebaConexion
    {
        public bool PruebaConectar()
        {

            try
            {
                SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-417K253;Initial Catalog=GNCRodrigues;Integrated Security=True");
                SqlCommand comando = new SqlCommand();
                comando.CommandText = "select * from Orden";
                comando.Connection = conexion;
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();

                return true;
            }

            catch
            {
                return false;

            }
        }
    }
}
