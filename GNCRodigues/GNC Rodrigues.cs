using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using GNCRodigues.Conexion;
using GNCRodigues.Entidad;

namespace GNCRodigues
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-417K253;Initial Catalog=GNCRodrigues;Integrated Security=True");



        public void Btn_ok_Click(object sender, EventArgs e)
        {
            Orden orden = new Orden();
            orden.Dominio = TB_Dominio.Text;
            orden.Vehiculo = TB_Vehiculo.Text;
            orden.Fecha = Dtp_Fecha .Value;
            orden.Nafta = CB_Nafta.Checked;
            orden.CortaCorriente = CB_Cortacorriente .Checked;
            orden.Detalles = TB_Detalles.Text;
            orden.Falla = TB_Fallas.Text;

            int presupuesto; // Declaración de la variable presupuesto
            if (int.TryParse(TB_presupuesto.Text, out presupuesto))
            {
                orden.Presupuesto = presupuesto;
            }
            else
            {
                // Manejo del caso en que el valor en el TextBox no sea un número válido
                MessageBox.Show("El presupuesto ingresado no es válido.");
                return; // Salir del método o tomar otras acciones según sea necesario
            }
            orden.ConfirmoCliente = CB_Confirmocliente.Checked;
            orden.AvisadoParaRetirar = CB_Avisopararetirar.Checked;
            orden.Total = TB_Total.Text;
            int telefono;
            if (int.TryParse(TB_Telefono.Text, out telefono))
            {
                orden.Telefono = telefono;
            }
            else
            {
                // Manejo del caso en que el valor en el TextBox no sea un número válido
                MessageBox.Show("El número de teléfono ingresado no es válido.");
                return; // Salir del método o tomar otras acciones según sea necesario
            }

            int result = AdminOrden.AgregarOrden(orden);


            //PruebaConexion conexion = new PruebaConexion();
            //MessageBox.Show("Conectando..." + conexion.PruebaConectar());

            if (result > 0 ) 
            {
                MessageBox.Show("exito al guardar");
                
            }

            else
            {
                MessageBox.Show("Error al guardar");
            }

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Dgv_historial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            //string consulta = "Select * from Orden";
            //SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            //DataTable dt = new DataTable();
            //adaptador.Fill(dt);
            //Dgv_historial.DataSource = dt;
        }

        private void tabPage2_Load(object sender, EventArgs e)
        {
            CargarDatos(); // Llama a la función que carga los datos en el DataGridView
        }

        private void CargarDatos()
        {
            string consulta = "SELECT * FROM Orden";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();

            try
            {
                conexion.Open();
                adaptador.Fill(dt);
                Dgv_historial.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gNCRodriguesDataSet.Orden' Puede moverla o quitarla según sea necesario.
            this.ordenTableAdapter.Fill(this.gNCRodriguesDataSet.Orden);

        }
    }
}
