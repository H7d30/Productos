using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Guia2
{
    public partial class Agregar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            // Definimos una cadena y le asignamos la cadena de conexión definida en el archivo Web.config
            string cadena =
           System.Configuration.ConfigurationManager.ConnectionStrings["CadenaConexion"].ConnectionString;
            /* Creamos un objeto de la clase SQLConnection indicando como parámetro la cadena de conexión 
            creada anteriormente */
            SqlConnection conexion = new SqlConnection(cadena);
            // Abrimos la conexión
            conexion.Open();
            /* Creamos un objeto de la clase SqlCommand con los datos cargados en los controles TextBox y 
            Calendar */
            SqlCommand comando = new SqlCommand("insert into Clientes(Nombre, Direccion, Telefono, FechaPrimeraCompra) " + "values('" + TxtNombre.Text + "', '" + 
           
            TxtDireccion.Text + "','" + TxtTelefono.Text + "','" +
            CalFecCompra.SelectedDate.ToShortDateString() + "')", conexion);
            // Le indicamos a SQL Server que ejecute el comando especificado anteriormente
            comando.ExecuteNonQuery();
            // Mostramos un mensaje si todo se realiza correctamente.
            LblMensaje.Text = "Se registró exitosamente el cliente.";
            // Cerramos la conexión
            conexion.Close();
            Limpiar();


        }

        public void Limpiar()
        {
            TxtNombre.Text = "";
            TxtDireccion.Text = "";
            TxtTelefono.Text = "";

        }
    }
    }
