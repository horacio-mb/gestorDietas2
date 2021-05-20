using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using capaNegocio;

namespace capaPresentacion
{
    public partial class frmTipoComida : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.mostrar();
        }

        protected void mostrar()
        {
            TipoComida tcom = new TipoComida();
            tcom.Nombre = txtBuscar.Text;
            gvRegis.DataSource = tcom.buscar();
            gvRegis.DataBind();

        }



        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            txtIdTipoComida.Text = "";
            txtNombre.Text = "";
            txtBuscar.Text = "";
            txtResp.Text = "";
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            TipoComida tcom = new TipoComida();
            tcom.Nombre = txtNombre.Text;
            if (tcom.guardar()) { txtResp.Text = "Registro Guardado"; }
            else { txtResp.Text = "Error al Registrar"; }


        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            TipoComida tcom = new TipoComida();
            tcom.id_TipoComida = Convert.ToInt32(txtIdTipoComida.Text);
            tcom.Nombre = txtNombre.Text;
            if (tcom.modificar()) { txtResp.Text = "Registro Modificado"; }
            else { txtResp.Text = "Error al Modificar"; }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            TipoComida tcom = new TipoComida();
            tcom.id_TipoComida = Convert.ToInt32(txtIdTipoComida.Text);
            if (tcom.eliminar()) { txtResp.Text = "Registro Eliminado"; }
            else { txtResp.Text = "Error al Eliminar"; }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            this.mostrar();
        }

        protected void gvRegis_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdTipoComida.Text = gvRegis.SelectedRow.Cells[0].Text;
            txtNombre.Text = gvRegis.SelectedRow.Cells[1].Text;
        }
    }
}