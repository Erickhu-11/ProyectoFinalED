using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Programa1
{
    public partial class frmprincipal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        //Validacion del Postback
            if(IsPostBack == false)
           {
               MenuItem vMenu;
               MenuItem vMenuChild;
               
               //Limpia los items del menu
               this.mnuPrincipal.Items.Clear();


                
                //Agrega una nueva opcion menu
               vMenu = new MenuItem("Mantenimientos", "mnuMantenimientos");

               //Agrega una nueva opcio menu hija
               vMenuChild = new MenuItem("Clientes", "mnuClientes");
               vMenu.ChildItems.Add(vMenuChild);

               vMenuChild = new MenuItem("Provedores", "mnuProvedores");
               vMenu.ChildItems.Add(vMenuChild);

               vMenuChild = new MenuItem("Articulos", "mnuArticulos");
               vMenu.ChildItems.Add(vMenuChild);

              
               this.mnuPrincipal.Items.Add(vMenu);

               vMenu = new MenuItem("Procesos", "mnuProcesos");


               vMenuChild = new MenuItem("Ordenes de Compra", "mnuCompra");
               vMenu.ChildItems.Add(vMenuChild);

               vMenuChild = new MenuItem("Venta de Productos", "mnuVenta");
               vMenu.ChildItems.Add(vMenuChild);

               this.mnuPrincipal.Items.Add(vMenu);

               vMenu = new MenuItem("Reportes", "mnuReportes");
               this.mnuPrincipal.Items.Add(vMenu);
           }

            Session["Usuario"] = "Bienvenido Nadia Ugalde Morales";
        }

        protected void mnuPrincipal_MenuItemClick(object sender, MenuEventArgs e)
        {
            Menu vMenu;
            String vOpcion;

            vMenu = (Menu)sender;
            vOpcion = vMenu.SelectedValue;

            switch (vOpcion)
                {

                case "mnuClientes": 
                    Response.Redirect("~/Listas/lClientes.aspx");
                    break;

               }
               

        }

       
    }
}