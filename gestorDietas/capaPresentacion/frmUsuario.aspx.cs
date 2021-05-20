using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using capaNegocio;

namespace capaPresentacion
{
    public partial class frmUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            mostrar();
        }

        protected void mostrar()
        {
            Usuario usu = new Usuario();
            usu.Cargo = txtBuscar.Text;
            gdvUsuario.DataSource = usu.buscar();
            gdvUsuario.DataBind();
        }



        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Usuario usu = new Usuario();
            usu.Usuario1 = txtUsuario.Text;
            usu.Correo = txtCorreo.Text;
            usu.Contraseña = txtContraseña.Text;
            usu.Nombre = txtNombre.Text;
            usu.Paterno = txtPaterno.Text;
            usu.Materno = txtMaterno.Text;
            usu.Cargo = txtCargo.Text;
            if (usu.guardar()) { lblResp.Text = "Usuario Guardado..!"; } else { lblResp.Text = "Error al Registrar"; }
            this.mostrar();

        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            Usuario usu = new Usuario();
            usu.Idusuario = Convert.ToInt32(txtIdusuario.Text);
            usu.Usuario1 = txtUsuario.Text;
            usu.Correo = txtCorreo.Text;
            usu.Contraseña = txtContraseña.Text;
            usu.Nombre = txtNombre.Text;
            usu.Paterno = txtPaterno.Text;
            usu.Materno = txtMaterno.Text;
            usu.Cargo = txtCargo.Text;
            if (usu.modificar()) { lblResp.Text = "Registro Modificado..!"; } else { lblResp.Text = "Error al Modificar"; }
            this.mostrar();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            Usuario usu = new Usuario();
            usu.Idusuario = Convert.ToInt32(txtIdusuario.Text);
            if (usu.eliminar()) { lblResp.Text = "Registro Eliminado..!"; } else { lblResp.Text = "Error al Eliminar"; }
            this.mostrar();
        }


        protected void btnBuscarC_Click(object sender, EventArgs e)
        {
            this.mostrar();
        }

        protected void gdvUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtIdusuario.Text = gdvUsuario.SelectedRow.Cells[0].Text;
            txtUsuario.Text = gdvUsuario.SelectedRow.Cells[1].Text;
            txtCorreo.Text = gdvUsuario.SelectedRow.Cells[2].Text;
            txtContraseña.Text = gdvUsuario.SelectedRow.Cells[3].Text;
            txtNombre.Text = gdvUsuario.SelectedRow.Cells[4].Text;
            txtPaterno.Text = gdvUsuario.SelectedRow.Cells[5].Text;
            txtMaterno.Text = gdvUsuario.SelectedRow.Cells[6].Text;
            txtCargo.Text = gdvUsuario.SelectedRow.Cells[7].Text;

        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtCorreo.Text = "";
            txtContraseña.Text = "";
            txtNombre.Text = "";
            txtPaterno.Text = "";
            txtMaterno.Text = "";
            txtCargo.Text = "";
        }
    }
}