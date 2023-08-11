using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Programa1.Listas
{
    public partial class lClientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.lblUsuario.Text = (String)Session["Usuario"]; 
        }
    }
}