using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IO1_Project.Modelo_Negocio;

namespace IO1_Project.GUI
{
    public partial class Registro_User : System.Web.UI.Page
    {
        Modelo_Negocio.Usuario usuario = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void enviar_Click(object sender, EventArgs e)
        {

            Page.Validate();
            if (Page.IsValid)
            {
                if (usuario.Registrar(iduser.Text, nombre.Text, apellido.Text, email.Text, passwd.Text))
                {
                    Response.Redirect(@"~\GUI\Registro_User.aspx?register=true");
                }
                else
                {
                    Response.Redirect(@"~\GUI\Registro_User.aspx?register=false");
                }
            }
         
        }
    }
}