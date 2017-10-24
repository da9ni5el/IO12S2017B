using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
namespace IO1_Project.Modelo_Negocio
{
    public class CarroBD
    {
        /* En esta clase se manipula toda la venta de peliculas. Agregar al carro
           eliminar item de carro
           cancelar toda la compra
           hacer efectiva la compra
           mano de saldo de cliente.
        */
        SqlConnection currentconection;
        SqlCommand comando;
        SqlDataReader reader;
        ConexionBD conexion;

        public CarroBD()
        {
            conexion = new ConexionBD();
        }

        //obtiene un id de carrito para las compras que se realicen. 
        public int getIdCarro( string iduser)
        {
            string query = "insert into (estado,id_usuario) values(@estado, @idusuario) select scope_identity()";
            try
            {
                currentconection = conexion.getConection();
                comando = new SqlCommand(query, currentconection);
                comando.Parameters.AddWithValue("estado", "pendiente");
                comando.Parameters.AddWithValue("idusuario", iduser);
                currentconection.Close();
                return Convert.ToInt32( comando.ExecuteScalar());
             
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                return 0;
            }
        }
        
        //inserta un nuevo item. pendiente de confirmar.
        public bool insertarItem(int idcarro, int idpelicula)
        {
            string query = "insert into ccarro(estado,id_carro, id_pelicula) values(@estado,@id_carro,@id_pelicula) select scope_identity()";
            try
            {
                currentconection = conexion.getConection();
                comando = new SqlCommand(query, currentconection);
                comando.Parameters.AddWithValue("estado", "activo");
                comando.Parameters.AddWithValue("id_carro", idcarro);
                comando.Parameters.AddWithValue("id_pelicula", idpelicula);

                comando.ExecuteNonQuery();
                currentconection.Close();
                return true;

            }catch(SqlException e)
            {
                Console.Write(e.ToString());
                return false;
            }
        }
    }
}