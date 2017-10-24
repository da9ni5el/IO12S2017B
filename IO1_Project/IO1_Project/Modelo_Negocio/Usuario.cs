using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace IO1_Project.Modelo_Negocio
{
    public class Usuario
    {
        private ConexionBD conn;
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader reader;
        public Usuario()
        {
            conn = new ConexionBD();
            reader = null;        
        }


        public bool Registrar(string iduser, string nombre, string apellido, string email, string passwd)
        {            
            String query = "insert into USUARIO(id_user, nombre, apellido, email, passwd, id_rol)  VALUES (@iduser,@nombre, @apellido, @email,@passwd,@rol)";
            try
            {
                conexion = conn.getConection();
                comando = new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue("iduser", iduser);
                comando.Parameters.AddWithValue("nombre", nombre);
                comando.Parameters.AddWithValue("apellido", apellido);
                comando.Parameters.AddWithValue("email", email);
                comando.Parameters.AddWithValue("rol", 0); //tipo 0 indica una persona sin ninguna clase de privilegios dentro del sitio. 
                comando.Parameters.AddWithValue("passwd", passwd);

                comando.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }

        }

    

        public string login(string iduser , string passwd)
        {
            string query = "select id_rol from usuario where id_user=@iduser and passwd=@passwd";
            try
            {
                conexion = conn.getConection();
                comando = new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue("iduser", iduser);
                comando.Parameters.AddWithValue("passwd", passwd);

                reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    return reader.GetInt32(0).ToString();
                }
                else
                {
                    return "error";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return "error";
            }
        }

        
    }
}