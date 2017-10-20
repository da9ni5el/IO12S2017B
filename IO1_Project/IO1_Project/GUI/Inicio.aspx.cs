using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IO1_Project.GUI
{
    public partial class Inicio : System.Web.UI.Page
    {
        Login login = new Login();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["rl"] == "true")
            {
                login.rol = null;
                Response.Redirect(@"~\GUI\Inicio.aspx?rl=null");
            }
        }
    }
}