using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IO1_Project.Modelo_Negocio
{
    public class Elenco
    {
        private string NOMBRE;
        private string APELLIDO;

        public string nombre { get { return NOMBRE; } set { NOMBRE = value; } }
        public string apellido { get { return APELLIDO; } set { APELLIDO = value; } }
    }
}