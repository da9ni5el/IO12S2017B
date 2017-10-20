using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IO1_Project.Modelo_Negocio;
namespace IO1_Project.GUI
{
    public partial class Login : System.Web.UI.Page
    {
        Modelo_Negocio.Usuario user = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public string rol
        {
            get { return (String)Session["rol"]; }
            set { Session["rol"] = value; }
        }

        protected void enviar_Click(object sender, EventArgs e)
        {
            Page.Validate();
            if (Page.IsValid)
            {
                rol = user.login(iduser.Text, password.Text);
                if (rol!="error")
                {                    
                    Response.Redirect("~/GUI/inicio.aspx?rl=" + rol);
                }
                else
                {                 
                    Response.Redirect("~/GUI/inicio.aspx?rl=null");
                }
            }
            //codigo que se ejecutara cuando se de click al boton.
            //enviara la informacion a la clase usuario. Y verificara si existe en la DB retornando asi el rol que juega dentro del sitio. 

        }
    }
}