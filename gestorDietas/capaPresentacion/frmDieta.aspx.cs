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
        protected void buscarCliente(object sender, EventArgs e)
        {
            miModalC.Show(); //inicia el modal Cliente
            gvCliente.DataBind(); //deja limpio la tabla de registros
        }
        protected void buscarUsuario(object sender, EventArgs e)
        {
            miModalU.Show(); //inicia el modal Cliente
            gvUsuario.DataBind(); //deja limpio la tabla de registros
        }
        protected void buscarComida(object sender, EventArgs e)
        {
            miModalCo.Show(); //inicia el modal Cliente
            gvComida.DataBind(); //deja limpio la tabla de registros
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
            diet.Nombre= txtNomDieta.Text;
            diet.FechaInicio= Convert.ToDateTime(txtFechaInicio.Text);
            diet.FechaInicio = Convert.ToDateTime(txtFechaFinal.Text);
            diet.IdCliente = Convert.ToInt32(txtIdCliente.Text);
            diet.IdUsuario = Convert.ToInt32(txtIdUsuario.Text);
            if (diet.guardar()) { lblResp.Text = "Dieta Registrada..!"; } else { lblResp.Text = "Error al Registrar"; }

            DietaComida dc;
            foreach (GridViewRow row in gvDetalle.Rows)
            {
                dc = new DietaComida();
                dc.IdComida = Convert.ToInt32(row.Cells[1].Text);
                dc.Porcion = Convert.ToInt32(((TextBox)row.Cells[3].FindControl("txtDistribucion")).Text);
                dc.guardar();
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {

            Dieta diet = new Dieta();
            diet.IdDieta = Convert.ToInt32(txtIdDieta.Text);
            diet.Nombre = txtNomDieta.Text;
            diet.FechaInicio = Convert.ToDateTime(txtFechaInicio.Text);
            diet.FechaInicio = Convert.ToDateTime(txtFechaFinal.Text);
            diet.IdCliente = Convert.ToInt32(txtIdCliente.Text);
            diet.IdUsuario = Convert.ToInt32(txtIdUsuario.Text);
            if (diet.guardar()) { lblResp.Text = "Dieta Registrada..!"; } else { lblResp.Text = "Error al Registrar"; }

            DietaComida dc1 = new DietaComida();
            dc1.IdDieta = Convert.ToInt32(txtIdDieta.Text);
            dc1.eliminar();

            DietaComida dc;
            foreach (GridViewRow row in gvDetalle.Rows)
            {
                dc = new DietaComida();
                dc.IdComida = Convert.ToInt32(row.Cells[1].Text);
                dc.Porcion = Convert.ToInt32(row.Cells[2].Text);
                dc.guardar();
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            DietaComida dc1 = new DietaComida();
            dc1.IdDieta = Convert.ToInt32(txtIdDieta.Text);
            dc1.eliminar();

            Dieta diet = new Dieta();
            diet.IdDieta = Convert.ToInt32(txtIdDieta.Text);
            if (diet.eliminar()) { lblResp.Text = "Dieta Eliminada..!"; } else { lblResp.Text = "Error al Eliminar"; }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            miModalD .Show(); //inicia el modal Dieta
            gvDieta.DataBind(); //deja limpio la tabla de registros
            lblError.Text = "";
        }

        protected void gvDetalle_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = gvDetalle.SelectedRow.Cells[1].Text;
            var db = (DataTable)Session["pedido"];
            detalleObj = null;
            foreach (DataRow row in db.Rows)
            {
                if (detalleObj == null)
                {
                    detalleObj = new DataTable("Carrito");
                    detalleObj.Columns.Add("idComida", System.Type.GetType("System.String"));
                    detalleObj.Columns.Add("descripcion", System.Type.GetType("System.String"));
                    detalleObj.Columns.Add("distribucion", System.Type.GetType("System.String"));
                    
                }
                string es = row["descripcion"].ToString();
                if (es != id)
                {
                    DataRow fila = detalleObj.NewRow();
                    fila[0] = Convert.ToInt32(row["idComida"].ToString());
                    fila[1] = Convert.ToString(row["descripcion"].ToString());
                    fila[2] = Convert.ToString(row["distribucion"].ToString());
                    detalleObj.Rows.Add(fila);
                }
            }
            Session["pedido"] = detalleObj;
            Session["prueba"] = detalleObj;
            gvDetalle.DataSource = detalleObj;
            gvDetalle.DataBind();//OJo con esta zona
        }

        protected void selectCliente()
        {
            Cliente cli = new Cliente();
            cli.Nombre = txtBuscarC.Text;
            gvCliente.DataSource = cli.buscar();
            gvCliente.DataBind();
        }
        protected void selectUsuario()
        {
            Usuario cli = new Usuario();
            cli.Nombre = txtBuscarU.Text;
            gvUsuario.DataSource = cli.buscar();
            gvUsuario.DataBind();
        }
        protected void selectComida()
        {
            Comida com = new Comida();
            com.Descripcion = txtBuscarCom.Text;
            gvComida.DataSource = com.buscar();
            gvComida.DataBind();
        }
      
        protected void selectDieta()
        {
            Dieta prod = new Dieta();
            gvDieta.DataSource = prod.buscar(txtBuscarD.Text);
            gvDieta.DataBind();
        }

        protected void txtBuscarC_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnBuscarC(object sender, EventArgs e)
        {
            selectCliente();
            miModalC.Show();
        }

        protected void btnCerrarCli(object sender, EventArgs e)
        {
            miModalC.Hide();
        }

        protected void gvCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdCliente.Text = gvCliente.SelectedRow.Cells[0].Text;
            txtCliente.Text = gvCliente.SelectedRow.Cells[1].Text + ' ' + gvCliente.SelectedRow.Cells[2].Text;
        }

        protected void btnBuscarCom(object sender, EventArgs e)
        {
            selectComida();
            miModalCo.Show();
        }

        protected void btnCerrarPro(object sender, EventArgs e)
        {
            miModalCo.Hide();
        }

        protected void gvComida_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idComida = gvComida.SelectedRow.Cells[0].Text;
            string descripcion = gvComida.SelectedRow.Cells[1].Text;
            string distribucion = gvComida.SelectedRow.Cells[2].Text;
            AgregarItem(idComida, descripcion, distribucion);
            miModalCo.Show();
        }

        protected void btnBuscarV(object sender, EventArgs e)
        {
            selectDieta();
            miModalD.Show();
        }

        protected void gvDieta_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdDieta.Text = gvDieta.SelectedRow.Cells[0].Text;
            txtNomDieta.Text = gvDieta.SelectedRow.Cells[1].Text;
            DateTime dt1 = Convert.ToDateTime(gvDieta.SelectedRow.Cells[2].Text);
            DateTime dt2 = Convert.ToDateTime(gvDieta.SelectedRow.Cells[3].Text);
            txtFechaInicio.Text = String.Format("{0:yyyy-MM-dd}", dt1);
            txtFechaFinal.Text = String.Format("{0:yyyy-MM-dd}", dt2);
            txtCliente.Text = gvDieta.SelectedRow.Cells[4].Text;
            txtUsuario.Text = gvDieta.SelectedRow.Cells[5].Text;
            Dieta diet = new Dieta();
            txtIdCliente.Text = diet.buscarClienteDieta(Convert.ToInt32(txtIdDieta.Text));

            DietaComida det = new DietaComida();
            DataTable detalle = new DataTable();
            detalle = det.buscar(Convert.ToInt32(txtIdDieta.Text));
            gvDetalle.DataSource = detalle;
            gvDetalle.DataBind();
            Session["prueba"] = detalle;
    
        }

        protected void btnCerrarDieta(object sender, EventArgs e)
        {
            miModalD.Hide();
        }

        protected void btnBuscarU(object sender, EventArgs e)
        {
            selectUsuario();
            miModalU.Show();
        }

        protected void btnCerrarUsu(object sender, EventArgs e)
        {
            miModalU.Hide();
        }

        protected void gvUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdUsuario.Text = gvUsuario.SelectedRow.Cells[0].Text;
            txtUsuario.Text = gvUsuario.SelectedRow.Cells[3].Text;
        }
    }
}