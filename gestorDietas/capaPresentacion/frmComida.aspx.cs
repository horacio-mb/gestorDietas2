using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using capaNegocio;

namespace capaPresentacion
{
    public partial class frmComida : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.mostrar();
            this.listarTipoComida();
        }

        private void mostrar()
        {
            Comida com = new Comida();
            com.Descripcion = txtBuscar.Text;
            gvRegis.DataSource = com.buscar();
            gvRegis.DataBind();
        }
        protected void listarTipoComida()
        {
            TipoComida cat = new TipoComida();
            if (IsPostBack == false)
            {
                dd1.DataSource = cat.listarTipoComida();
                dd1.DataValueField = "idTipoComida";
                dd1.DataTextField = "nombre";
                dd1.DataBind();
                dd1.Items.Insert(0, new ListItem("Selecciona", "0"));
            }
        }
        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            txtIdComida.Text = "";
            txtDescripcion.Text = "";
            dd1.SelectedIndex = dd1.Items.IndexOf(dd1.Items.FindByValue("0"));

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Comida com = new Comida();

            com.Descripcion = txtDescripcion.Text;
            com.Id_TipoComida = Convert.ToInt32(dd1.SelectedValue.ToString());
            if (com.guardar()) { txtResp.Text = "Registro Guardado"; }
            else { txtResp.Text = "Error al Registrar"; }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            Comida com = new Comida();
            com.Id_Comida = Convert.ToInt32(txtIdComida.Text);
            com.Descripcion = txtDescripcion.Text;
            com.Id_TipoComida = Convert.ToInt32(dd1.SelectedValue.ToString());
            if (com.modificar()) { txtResp.Text = "Registro Modificado"; }
            else { txtResp.Text = "Error al Modificar"; }
            this.mostrar();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            Comida com = new Comida();
            com.Id_Comida = Convert.ToInt32(txtIdComida.Text);
            if (com.eliminar()) { txtResp.Text = "Registro eliminado..!"; } else { txtResp.Text = "Error al eliminar; "; }
            this.mostrar();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            this.mostrar();
        }

        protected void gvRegis_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtIdComida.Text = gvRegis.SelectedRow.Cells[0].Text;
            txtDescripcion.Text = gvRegis.SelectedRow.Cells[1].Text;
            dd1.SelectedIndex = dd1.Items.IndexOf(dd1.Items.FindByText(gvRegis.SelectedRow.Cells[1].Text));

        }

        protected void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}