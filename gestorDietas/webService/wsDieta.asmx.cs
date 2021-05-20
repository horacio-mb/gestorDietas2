using capaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace webService
{
    /// <summary>
    /// Descripción breve de wsDieta
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsDieta : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet buscarDietaPorUsuario(string usuario)
        {
            clsConexion con = new clsConexion();
            string s;
            s = "select cliente.nombre as NombreCliente,dieta.nombre as NombreDieta, usuario.usuario as ID from cliente,dieta,usuario where dieta.idUsuario=usuario.idUsuario and cliente.idCliente=dieta.idCliente and usuario.usuario='" + usuario + "'";
            DataSet ds = new DataSet();
            con.ejecutarSQL(s, "tc", ds);
            return ds;
        }




        [WebMethod]
        public DataSet buscarDietaPorCliente(string nom)
        {
            clsConexion con = new clsConexion();
            string s;
            s = "select cliente.nombre as NombreCliente,dieta.nombre as NombreDieta from cliente,dieta where cliente.idCliente=dieta.idCliente AND cliente.nombre='" + nom + "'";
            DataSet ds = new DataSet();
            con.ejecutarSQL(s, "tc", ds);
            return ds;
        }

        [WebMethod]
        public DataSet buscarDietaPorRangoFecha(string fecha1, string fecha2)
        {
            clsConexion con = new clsConexion();
            string s;
            s = "select idDieta,nombre, date_format(fechaInicio, '%Y-%m-%d') as fechaInicio, date_format(fechaFinal, '%Y-%m-%d') as fechaFinal from dieta where fechaInicio >= CAST('" + fecha1 + "' AS datetime) and fechaFinal <= CAST('" + fecha2 + "' AS datetime)";
            DataSet ds = new DataSet();
            con.ejecutarSQL(s, "tc", ds);
            return ds;
        }
    }
}
