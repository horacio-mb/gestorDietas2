using capaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace capaPresentacion
{
    public partial class frmCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.mostrar();
        }

        protected void mostrar()
        {
            Cliente client = new Cliente();
            client.Nombre = txtBuscar.Text;
            gvRegis.DataSource = client.buscar();
            gvRegis.DataBind();
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            //guardar
            Cliente client = new Cliente();
            client.Nombre = txtNombre.Text;
            client.Paterno = txtPaterno.Text;
            client.Materno = txtMaterno.Text;
            client.Fecha_nacimiento = Convert.ToDateTime(txtNacimiento.Text);
            client.Correo = txtCorreo.Text;
            client.Telefono = txtTelefono.Text;
            if (rb1.Checked) { client.Sexo = "M"; } else { client.Sexo = "F"; }
            if (client.guardar()) { txtResp.Text = "Registro Guardado..!"; } else { txtResp.Text = "Error al Registrar"; }
            this.mostrar();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            this.mostrar();
        }

        protected void gvRegis_SelectedIndexChanged(object sender, EventArgs e)
        {
            rb1.Checked = false;
            rb2.Checked = false;
            txtIdCliente.Text = gvRegis.SelectedRow.Cells[0].Text;
            txtNombre.Text = gvRegis.SelectedRow.Cells[1].Text;
            txtPaterno.Text = gvRegis.SelectedRow.Cells[2].Text;
            txtMaterno.Text = gvRegis.SelectedRow.Cells[3].Text;
            DateTime dt = Convert.ToDateTime(gvRegis.SelectedRow.Cells[4].Text);
            txtNacimiento.Text = String.Format("{0:yyyy-MM-dd}", dt);
            txtCorreo.Text = gvRegis.SelectedRow.Cells[5].Text;
            txtTelefono.Text = gvRegis.SelectedRow.Cells[6].Text;
            if (gvRegis.SelectedRow.Cells[7].Text == "M") { rb1.Checked = true; } else { rb2.Checked = true; }

        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            Cliente client = new Cliente();
            client.Nombre = txtNombre.Text;
            client.Paterno = txtPaterno.Text;
            client.Materno = txtMaterno.Text;
            client.Fecha_nacimiento = Convert.ToDateTime(txtNacimiento.Text);
            client.Correo = txtCorreo.Text;
            client.Telefono = txtTelefono.Text;
            if (rb1.Checked) { client.Sexo = "M"; } else { client.Sexo = "F"; }
            if (client.modificar()) { txtResp.Text = "Registro Modificado..!"; } else { txtResp.Text = "Error al Modificar"; }
            this.mostrar();
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            txtIdCliente.Text = "";
            txtNombre.Text = "";
            txtPaterno.Text = "";
            txtMaterno.Text = "";
            txtNacimiento.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            rb1.Checked = false;
            rb2.Checked = false;
            txtResp.Text = "";
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            Cliente client = new Cliente();
            client.Id = Convert.ToInt32(txtIdCliente.Text);
            if (client.eliminar()) { txtResp.Text = "Registro Eliminado..!"; } else { txtResp.Text = "Error al Eliminar"; }
            this.mostrar();
        }
    }
}