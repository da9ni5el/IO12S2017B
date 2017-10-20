using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
namespace IO1_Project.Modelo_Negocio
{
    public class ConexionBD
    {

        public SqlConnection getConection()
        {
            try
            {
                SqlConnection conexion = new SqlConnection(@"Data Source=DA9NI5EL_LML\DANIEL;Initial Catalog=Io1_project;Integrated Security=True");
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;                              
            }
        }
    }
}