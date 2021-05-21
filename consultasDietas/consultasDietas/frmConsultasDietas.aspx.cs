using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace consultasDietas
{
    public partial class frmConsultasDietas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /*
        protected void btnBuscarU_Click(object sender, EventArgs e)
        {
            wsDieta.wsDieta obj = new wsDieta.wsDieta();
            gvdUsuario.DataSource = obj.buscarDietaPorUsuario(txtBuscarU.Text);
            gvdUsuario.DataBind();
        }*/

        protected void btnBuscarC_Click(object sender, EventArgs e)
        {
            wsDieta.wsDieta obj = new wsDieta.wsDieta();
            gvdBuscarC.DataSource = obj.mostrarDietasPorCliente(txtBuscarC.Text);
            gvdBuscarC.DataBind();
        }

        protected void btnRango_Click(object sender, EventArgs e)
        {
            wsDieta.wsDieta obj = new wsDieta.wsDieta();
            gvdFecha.DataSource = obj.buscarDietaPorRangoFecha(txtFecha1.Text, txtFecha2.Text);
            gvdFecha.DataBind();
        }

        protected void btnDetalleCliente_Click(object sender, EventArgs e)
        {
            wsDieta.wsDieta obj = new wsDieta.wsDieta();
            gvdDetalleClienteDieta.DataSource = obj.mostrarDetallePorCliente(txtCliente.Text);
            gvdDetalleClienteDieta.DataBind();
        }

        protected void btnNomDieta_Click(object sender, EventArgs e)
        {
            wsDieta.wsDieta obj = new wsDieta.wsDieta();
            gvDetalleDieta.DataSource = obj.mostrarDetallePorDieta(txtNomDieta.Text);
            gvDetalleDieta.DataBind();
        }

        protected void btnSexo1_Click(object sender, EventArgs e)
        {
            wsDieta.wsDieta obj = new wsDieta.wsDieta();
            string sexo;
            if (rb1.Checked == true) { sexo = "M"; }
            else { sexo = "F"; }
            gvSexo1.DataSource = obj.mostrarClientePorSexo(sexo);
            gvSexo1.DataBind();
        }

        protected void btnSexo2_Click(object sender, EventArgs e)
        {
            wsDieta.wsDieta obj = new wsDieta.wsDieta();
            string sexo;
            if (rb3.Checked == true) { sexo = "M"; }
            else { sexo = "F"; }
            gvSexo2.DataSource = obj.contarClientePorSexo(sexo);
            gvSexo2.DataBind();
        }
    }
}