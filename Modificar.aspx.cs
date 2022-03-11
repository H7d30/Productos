using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace Guia2
{
    public partial class Modificar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnBuscar_Click(object sender, EventArgs e)
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
            SqlCommand comando = new SqlCommand("select Nombre, Direccion, Telefono from Clientes " +
            " where Nombre='" + TxtCliente.Text + "'", conexion);
            /* Creamos un objeto de la clase SqlDataReader e inicializándolo mediante la llamada del 
            método ExecuteReader de la clase SQLCommand */
            SqlDataReader registro = comando.ExecuteReader();
            /* Recorremos el SqlDataReader (como este caso puede retornar cero o un registro) lo hacemos 
            mediante un "if".
            Si el método Read retorna “true”, luego podemos acceder a la fila recuperada con el select 
            y la mostramos en los TextBox */
            if (registro.Read())
            {
                TxtDireccion.Text = registro["Direccion"].ToString();
                TxtTelefono.Text = registro["Telefono"].ToString();
            }
            // Si retorna "False" mostramos un mensaje informativo
            else
                LblMensaje.Text = "No existe un cliente con el nombre indicado. ";
            // Cerramos la conexión
            conexion.Close();
        }

        protected void BtnModificar_Click(object sender, EventArgs e)
        {
            // Definimos una cadena y le asignamos la cadena de conexión definida en el archivo Web.config
            string cadena =
           System.Configuration.ConfigurationManager.ConnectionStrings["CadenaConexion"].ConnectionString;
            /* Creamos un objeto de la clase SQLConnection indicando como parámetro la cadena de conexión 
            creada anteriormente */
            SqlConnection conexion = new SqlConnection(cadena);
            // Abrimos la conexión
            conexion.Open();
            // Creamos un objeto de la clase SqlCommand con los datos cargados en los controles TextBox
            SqlCommand comando = new SqlCommand("update Clientes set " + "Direccion ='" + TxtDireccion.Text
            + "', Telefono ='" + TxtTelefono.Text + "' where Nombre='" +
            TxtCliente.Text + "'", conexion);
            /* Definimos una variable para capturar el dato devuelto por el método ExecuteNonQuery: 
            retorna un entero y representa la cantidad de filas actualizadas en la tabla */
            int cantidad = comando.ExecuteNonQuery();
            // Si retorna 1 significa que el cliente existe
            if (cantidad == 1)
                LblMensaje1.Text = "Datos Modificados exitosamente. ";
            else
                LblMensaje1.Text = "No existe el cliente indicado. ";
            // Cerramos la conexión
            conexion.Close();


        }
    }
}