using GNCRodigues.Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GNCRodigues.Conexion;
using GNCRodigues.Entidad;

namespace GNCRodigues.Conexion
{
    public class AdminOrden
    {
        public static int AgregarOrden(Orden orden)
        {
            int retorna = 0;

            using (SqlConnection conexion = ConexionBD.Obtenerconexion())
            {
                string query = @"INSERT INTO persona 
                        (Dominio, Vehiculo, Fecha, Nafta, CortaCorriente, Detalles, Falla, Presupuesto, ConfirmoCliente, AvisoParaRetirar, Total, Telefono) 
                        VALUES 
                        (@Dominio, @Vehiculo, @Fecha, @Nafta, @CortaCorriente, @Detalles, @Falla, @Presupuesto, @ConfirmoCliente, @AvisoParaRetirar, @Total, @Telefono)";

                SqlCommand comando = new SqlCommand(query, conexion);

                // Agregar parámetros
                comando.Parameters.AddWithValue("@Dominio", orden.Dominio);
                comando.Parameters.AddWithValue("@Vehiculo", orden.Vehiculo);
                comando.Parameters.AddWithValue("@Fecha", orden.Fecha);
                comando.Parameters.AddWithValue("@Nafta", orden.Nafta);
                comando.Parameters.AddWithValue("@CortaCorriente", orden.CortaCorriente);
                comando.Parameters.AddWithValue("@Detalles", orden.Detalles);
                comando.Parameters.AddWithValue("@Falla", orden.Falla);
                comando.Parameters.AddWithValue("@Presupuesto", orden.Presupuesto);
                comando.Parameters.AddWithValue("@ConfirmoCliente", orden.ConfirmoCliente);
                comando.Parameters.AddWithValue("@AvisoParaRetirar", orden.AvisadoParaRetirar);
                comando.Parameters.AddWithValue("@Total", orden.Total);
                comando.Parameters.AddWithValue("@Telefono", orden.Telefono);

                try
                {
                    conexion.Open();
                    retorna = comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al insertar en la base de datos: " + ex.Message);
                    // Manejar la excepción según sea necesario
                }
                finally
                {
                    conexion.Close();
                }
            }

            return retorna;
        }
    }
}
