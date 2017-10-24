using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IO1_Project.Modelo_Negocio
{
    public class Comentario
    {
        private int IDCOMENTARIO;
        private string DESCRIPCION; //informacion que se mostrara en la pagina
        private string IDUSUARIO; // se mostrara en la pagina.
        private int IDPELICULA;

        public int idcomentario { get { return IDCOMENTARIO; } set { IDCOMENTARIO = value; } }
        public string descripcion { get { return DESCRIPCION; } set { DESCRIPCION = value; } }
        public string idusuario { get { return IDUSUARIO; } set { IDUSUARIO = value; } }
        public int idpelicula { get { return IDPELICULA; } set { IDPELICULA = value; } }

    }
}