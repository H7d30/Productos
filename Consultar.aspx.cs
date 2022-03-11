using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace  Guia2  

{
    public partial class Consultar : System.Web.UI.Page
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
            SqlCommand comando = new SqlCommand("select CodCliente, Nombre, Direccion, Telefono, FechaPrimeraCompra from Clientes " + " where Nombre = '" + 
           
            TxtCliente.Text + "'", conexion);
            /* Creamos un objeto de la clase SqlDataReader e inicializándolo mediante la llamada del 
            método ExecuteReader de la clase SQLCommand */
            SqlDataReader registro = comando.ExecuteReader();
            /* Recorremos el SqlDataReader (como este caso puede retornar cero o un registro) lo hacemos 
            mediante un "if" */
            /* Si el método Read retorna “true”, luego podemos acceder a la fila recuperada con el select 
 y la mostramos en la etiqueta */
            if (registro.Read())
                LblMensaje.Text = "Código del cliente: " + registro["CodCliente"] + "<br>" +
                "Nombre: " + registro["Nombre"] + "<br>" +
                "Dirección: " + registro["Direccion"] + "<br>" +
                "Teléfono: " + registro["Telefono"] + "<br>" +
                "Fecha de primera compra: " + registro["FechaPrimeraCompra"];
            else // Si retorna "False" mostramos un mensaje informativo
                LblMensaje.Text = "No existe un cliente con el nombre ingresado. ";
            // Cerramos la conexión
            conexion.Close();





        }
    }
}