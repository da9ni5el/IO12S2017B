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
        public PeliculaDB()
        {
            conexion = new ConexionBD();
            reader = null;
            currentconexion = null;
            comando = null;
        }

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
    }
}