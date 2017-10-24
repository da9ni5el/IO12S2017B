using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IO1_Project.Modelo_Negocio
{
    public class Pelicula
    {
        private int IDPELICULA;
        private string NOMBRE;
        private string SINOPSIS;
        private string IMAGEN;
        private string TRAILER;
        private int IDCATEGORIA;
        private double PRECIO;
        private string DIRECTOR;

        public Pelicula() { }
   
        public int idpelicula { get { return IDPELICULA; } set { IDPELICULA = value; } }
        public string nombre { get { return NOMBRE; } set { NOMBRE = value; } }
        public string sinopsis { get { return SINOPSIS; } set { SINOPSIS = value; } }
        public string imagen { get { return IMAGEN; } set { IMAGEN = value; } }
        public string trailer { get { return TRAILER; } set {TRAILER=value; } }
        public int idcategoria { get { return IDCATEGORIA; } set { IDCATEGORIA = value; } }
        public double precio { get { return PRECIO; } set { PRECIO = value; } }
        public string director { get { return DIRECTOR; } set { DIRECTOR = value; } }
    }
}