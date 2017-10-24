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
        Login login = new Login();
        private PeliculaDB pelidb = new PeliculaDB();//ejecuta las consultas a la DB
        private Modelo_Negocio.Pelicula peli; // abstraccion de un objeto de tipo pelicula.
        private Elenco elenco;
        //private Comentario comentario;
        private List<string> comentarioswrite = new List<string>();
        protected string idp = string.Empty;
        protected string video;

        protected void Page_Load(object sender, EventArgs e)
        {

            idp = Request.QueryString["idp"];            
            obtenerPelicula();
            isuser();
            escribirComentarios();


            if (agregado=="true")
            {
                comprar.Enabled = false;
                comprar.Text = "Item agregado al carrito de compra";
            }
                 
        }

        public string agregado
        {
            get { return (String)Session["btnclick"]; }
            set { Session["btnclick"] = value; }
        }

        //comprueba si la persona es miembro de la pagina. para mostrar la caja de comentarios
        private void isuser()
        {
            if (login.rol==null)
            {
                txtcomment.Visible = false;
                buttonenviar.Visible = false;
            }
        }

        //esta wea muestra los comentarios. 
        private void escribirComentarios()
        {
            string auxiliar = string.Empty;
            try
            {
                string media = "<div class=\"media\">" +
                               "<div class=\"media-left\">" +
                                "<img src = \"../imagenes carousel/avatar.jpg\" class=\"media-object\" style=\"width: 60px\">" +
                                "</div>"; //falta una etiqueta de cierre
                string cuerpo = "";
                List<Comentario> comentarios = pelidb.getComentarios(Convert.ToInt32(idp));
                if (comentarios.Count != 0)
                {
                    for (int i = 0; i <= comentarios.Count - 1; i++)
                    {
                        cuerpo = "<div class=\"media-body\">" +
                             "<h4 class=\"media-heading\">" + comentarios[i].idusuario + "</h4>" +
                             "<p>" + comentarios[i].descripcion + "</p>" +
                            "</div>" + "</div>";

                        comentarioswrite.Add(media + cuerpo);
                        auxiliar += media + cuerpo;
                        formcontenedor.InnerHtml = auxiliar;

                    }
                }
            }
            catch (Exception e)
            {
                Console.Write(e.ToString());                
            }           


        }


            //pendiente de trabajar
        private void obtenerPelicula()
        {
         peli= pelidb.getPelicula(Convert.ToInt32(idp));
            if (peli!=null)
            {
                
                Image1.ImageUrl = peli.imagen;
                titulo.InnerText = peli.nombre;
                sinopsis.InnerText = peli.sinopsis;
                //muestra o no el trailer de la pelicula
                #region 
                if (peli.trailer=="nulo")
                {
                    container.Visible = false;
                }
                else
                {
                    cargarVideo(peli);
                }
                #endregion

                escribirDescripcion(peli);
            }


        }

        private void escribirDescripcion(Modelo_Negocio.Pelicula peli)
        {

            string auxiliar= string.Empty;
            List<Elenco> elencos = pelidb.getElenco(Convert.ToInt32(idp));
            if (elencos.Count>0)
            {
                for (int i = 0; i <=elencos.Count-1 ; i++)
                {
                    auxiliar += elencos[i].nombre + " " + elencos[i].apellido + ",";
                }
            }

           
            actores.InnerHtml = "<span class=\"glyphicon glyphicon-bullhorn\"></span> " + peli.director + "<br/>"+
                                "<span class=\"glyphicon glyphicon-star\"></span>" + auxiliar +
                                "<br/><h3>Precio Q."+peli.precio+"</h3>";
        }


        //carga el video al html
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

        protected void enviar_Click(object sender, EventArgs e)
        {
            if (pelidb.insertComment(Convert.ToInt32(idp),login.username,TextBox1.Text))
            {
                TextBox1.Text = null;
                Response.Write("<script>alert('ingresado correctamente')</script>");
            }
            else
            {
                Response.Write("<script>alert('Error')</script>");
            }
        }

        protected void comprar_Click(object sender, EventArgs e)
        {
            //este boton envia el item al carrito de compra. 
            agregado = "true";
        }
    }
}