using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace capaPresentacion
{
    public partial class frmDieta : System.Web.UI.Page
    {
        DataTable dtb;
        DataTable carrito = new DataTable();
        DataTable detalleObj = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarDetalle();
            txtFechaInicio.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }
        public void CargarDetalle()
        {
            if (Session["pedido"] == null)
            {
                dtb = new DataTable("Carrito");
                dtb.Columns.Add("idComida", System.Type.GetType("System.String"));
                dtb.Columns.Add("descripcion", System.Type.GetType("System.String"));
                dtb.Columns.Add("distribucion", System.Type.GetType("System.String"));

                Session["pedido"] = dtb;
                Session["prueba"] = dtb;
            }
            else
            {
                Session["pedido"] = Session["prueba"];
            }
        }
    }
}