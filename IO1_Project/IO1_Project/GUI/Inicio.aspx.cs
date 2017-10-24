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
        protected string currentrol= string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (login.rol!=null)
            {
                currentrol = login.rol;
            }


            if (Request.QueryString["logout"] == "true")
            {
                login.rol =currentrol = null;
                
                //Response.Redirect(@"~\GUI\Inicio.aspx");
            }            
        }
    }
}