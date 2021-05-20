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

        protected void btnBuscarU_Click(object sender, EventArgs e)
        {
            wsDieta.wsDieta obj = new wsDieta.wsDieta();
            gvdUsuario.DataSource = obj.buscarDietaPorUsuario(txtBuscarU.Text);
            gvdUsuario.DataBind();
        }

        protected void btnBuscarC_Click(object sender, EventArgs e)
        {
            wsDieta.wsDieta obj = new wsDieta.wsDieta();
            gvdBuscarC.DataSource = obj.buscarDietaPorCliente(txtBuscarC.Text);
            gvdBuscarC.DataBind();
        }

        protected void btnRango_Click(object sender, EventArgs e)
        {
            wsDieta.wsDieta obj = new wsDieta.wsDieta();
            gvdFecha.DataSource = obj.buscarDietaPorRangoFecha(txtFecha1.Text, txtFecha2.Text);
            gvdFecha.DataBind();
        }
    }
}