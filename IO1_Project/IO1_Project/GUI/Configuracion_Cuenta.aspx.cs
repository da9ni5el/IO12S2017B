using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IO1_Project.GUI
{
    public partial class Configuracion_Cuenta : System.Web.UI.Page
    {
        Login login = new Login();
        protected string currentrol;
        protected void Page_Load(object sender, EventArgs e)
        {
            //mandar a llamar el iduser para hacer la consulta respectiva y llenar el perfil del usuario.
            if (login.rol!=null)
            {
                currentrol = login.rol;
            }
            else
            {
                Response.Redirect(@"~\GUI\Inicio.aspx");
            }
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {

        }

        protected void password_Click(object sender, EventArgs e)
        {

        }
    }
}