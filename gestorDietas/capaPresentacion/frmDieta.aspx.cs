using capaNegocio;
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
        public void AgregarItem(string idComida, string descripcion, string distribucion)
        {
            carrito = (DataTable)Session["pedido"];
            DataRow fila = carrito.NewRow();
            fila[0] = idComida;
            fila[1] = descripcion;
            fila[2] = distribucion;
            carrito.Rows.Add(fila);
            Session["pedido"] = carrito;
            cargarcarrito();
        }
        public void cargarcarrito()
        {
            gvDetalle.DataSource = Session["pedido"];
            gvDetalle.DataBind();
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        protected void limpiar()
        {
            txtIdDieta.Text = "";
            txtIdCliente.Text = "";
            txtIdUsuario.Text = "";
            txtNomDieta.Text = "";
            txtFechaInicio.Text = "";
            txtFechaFinal.Text = "";
            txtCliente.Text = "";
            txtUsuario.Text = "";
            gvDetalle.DataBind();
            Session["pedido"] = null;
            Session["prueba"] = null;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Dieta diet = new Dieta();

            diet.Fecha = Convert.ToDateTime(txtFechaVenta.Text);
            
            vent.Idcliente = Convert.ToInt32(txtIdCliente.Text);
            if (vent.guardar()) { lblResp.Text = "Venta Registrada..!"; } else { lblResp.Text = "Error al Registrar"; }

            DetalleVenta dv;
            foreach (GridViewRow row in gvDetalle.Rows)
            {
                dv = new DetalleVenta();
                dv.Idproducto = Convert.ToInt32(row.Cells[1].Text);
                dv.Preciov = Convert.ToDecimal(row.Cells[5].Text);
                dv.Cantidad = Convert.ToInt32(((TextBox)row.Cells[4].FindControl("txtCantidad")).Text);
                dv.guardar();
            }

            wsDieta.wsDieta obj = new wsDieta.wsDieta();
            obj.guardarDieta(txtNomDieta.Text, txtFechaInicio.Text, txtFechaFinal.Text, txtIdCliente.Text, txtIdUsuario.Text);
            limpiar();
        }
    }
}