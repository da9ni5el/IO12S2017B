using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IO1_Project.Modelo_Negocio;

namespace IO1_Project.GUI
{
    public partial class Pelicula : System.Web.UI.Page
    {
        private PeliculaDB pelidb = new PeliculaDB();//ejecuta las consultas a la DB
        private Modelo_Negocio.Pelicula peli; // abstraccion de un objeto de tipo pelicula.
        protected string idp = string.Empty;
        protected string video;

        protected void Page_Load(object sender, EventArgs e)
        {
            idp = Request.QueryString["idp"];            
            obtenerPelicula();
            coment.Visible = false;      
        }

        private void obtenerPelicula()
        {
         peli= pelidb.getPelicula(Convert.ToInt32(idp));
            if (peli!=null)
            {
                Image1.ImageUrl = peli.imagen;
                titulo.InnerText = peli.nombre;
                sinopsis.InnerText = peli.sinopsis;
                if (peli.trailer=="nulo")
                {
                    container.Visible = false;
                }
                else
                {
                    cargarVideo(peli);
                }
            }
            
                        
        }

       

        protected void cargarVideo(Modelo_Negocio.Pelicula peli)
        {
            string youtubeurl = peli.trailer;
            string vcode = youtubeurl.Substring(youtubeurl.LastIndexOf("v=") + 2);
            if (vcode.Contains("&"))
            {
                vcode = vcode.Substring(0, vcode.LastIndexOf("&"));
            }

            string html = "<object width='{0}' height='{1}' " +
            "data='http://www.youtube.com/v/{2}&autoplay=0' codetype='application/x-shockwave-flash'>" +
            "<param name='movie' value='http://www.youtube.com/v/{2}&autoplay=0'></param></object>";

            string swith = "640px";
            string sheigth = "400px";
            container.InnerHtml = string.Format(html, swith, sheigth, vcode);
        }
    }
}