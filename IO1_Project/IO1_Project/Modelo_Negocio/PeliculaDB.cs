using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
namespace IO1_Project.Modelo_Negocio
{
    public class PeliculaDB
    {
        private SqlConnection currentconexion;
        private SqlCommand comando;
        private SqlDataReader reader;
        private ConexionBD conexion;
        private Pelicula pelicula;
        private Elenco elenco;
        private Comentario comentario;
        public PeliculaDB()
        {
            conexion = new ConexionBD();
            reader = null;
            currentconexion = null;
            comando = null;
        }


        //botiene una pelicula seleccionada
        public Pelicula getPelicula(int idpelicula)
        {
            string query = "select * from pelicula where id_pelicula=@idpelicula";
            try
            {
                currentconexion = conexion.getConection();
                comando = new SqlCommand(query, currentconexion);

                comando.Parameters.AddWithValue("idpelicula", idpelicula);
                reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    pelicula = new Pelicula();

                    pelicula.idpelicula = reader.GetInt32(0);
                    pelicula.nombre = reader.GetString(1);
                    pelicula.sinopsis = reader.GetString(2);
                    pelicula.imagen = reader.GetString(3);
                    pelicula.trailer = reader.GetString(4);
                    pelicula.idcategoria = reader.GetInt32(5);
                    pelicula.precio = reader.GetSqlDecimal(6).ToDouble();
                    pelicula.director = reader.GetString(7);
                    currentconexion.Close();
                    return pelicula;
                }
                return null;

            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.ToString());         
                return null;
            }
        }

        //obtiene el elenco de la pelicula
        public List<Elenco> getElenco(int idpelicula)
        {
            List<Elenco> elencos = new List<Elenco>();
            string query = "select actor.nombre, actor.apellido from actor,elenco,pelicula where elenco.id_pelicula=@idpelicula"+
                " and elenco.id_actor=actor.id_actor";
            try
            {
                currentconexion = conexion.getConection();
                comando = new SqlCommand(query, currentconexion);
                comando.Parameters.AddWithValue("idpelicula", idpelicula);

                reader = comando.ExecuteReader();
                while(reader.Read())
                {
                    elenco = new Elenco();

                    elenco.nombre = reader.GetString(0);
                    elenco.apellido = reader.GetString(1);
                    elencos.Add(elenco);                    
                }
                currentconexion.Close();
                return elencos;
            }
            catch (Exception e)
            {

                Console.Write(e.ToString());
                return null;
            }
        }

        //ingresa un nuevo comentario
        public bool insertComment(int idpelicula, string iduser, string comentario)
        {
            string query = "insert into comentario (descripcion,id_usuario,id_pelicula) values(@comentario, @idusuario, @idpelicula)";
            try
            {
                currentconexion = conexion.getConection();
                comando = new SqlCommand(query, currentconexion);

                comando.Parameters.AddWithValue("comentario", comentario);
                comando.Parameters.AddWithValue("idusuario", iduser);
                comando.Parameters.AddWithValue("idpelicula", idpelicula);

                comando.ExecuteNonQuery();

                currentconexion.Close();
                return true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }

        //retorna el listado de comentarios
        public List<Comentario> getComentarios(int idpelicula)
        {
            List<Comentario> listcoment = new List<Comentario>();
            string query = "select descripcion, id_usuario from comentario where id_pelicula=@idpelicula";
            try
            {
                currentconexion = conexion.getConection();
                comando = new SqlCommand(query, currentconexion);
                comando.Parameters.AddWithValue("idpelicula", idpelicula);

                
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    comentario = new Comentario();
                    comentario.descripcion = reader.GetString(0);
                    comentario.idusuario = reader.GetString(1);
                    listcoment.Add(comentario);
                    
                }
                return listcoment;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }


    }
}