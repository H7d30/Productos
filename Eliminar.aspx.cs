using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace Guia2
{
    public partial class Eliminar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Definimos una cadena y le asignamos la cadena de conexión definida en el archivo Web.config
            string cadena =
           System.Configuration.ConfigurationManager.ConnectionStrings["CadenaConexion"].ConnectionString;
            /* Creamos un objeto de la clase SQLConnection indicando como parámetro la cadena de conexión 
            creada anteriormente */
            SqlConnection conexion = new SqlConnection(cadena);
            // Abrimos la conexión 
            conexion.Open();
            // Creamos un objeto de la clase SqlCommand con el dato cargado en el control TextBox
            SqlCommand comando = new SqlCommand("delete from Clientes where Nombre='" + TxtCliente.Text + "'", conexion);
            /* Definimos una variable para capturar el dato devuelto por el método ExecuteNonQuery: 
           retorna un entero y representa la cantidad de filas borradas de la tabla */
            int cantidad = comando.ExecuteNonQuery();
            // Si retorna 1 significa que el cliente existe
            if (cantidad == 1)
                LblMensaje.Text = "Se borró el cliente indicado. ";
            else
                LblMensaje.Text = "No existe un cliente con el nombre indicado. ";
            // Cerramos la conexión
            conexion.Close();
        }
    }
}