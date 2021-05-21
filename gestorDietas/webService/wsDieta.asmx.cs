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
    /// 
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsDieta : System.Web.Services.WebService
    {

        /*[WebMethod]
        public DataSet buscarDietaPorUsuario(string usuario)
        {
            clsConexion con = new clsConexion();
            string s;
            s = "select cliente.nombre as NombreCliente,dieta.nombre as NombreDieta, usuario.usuario as ID from cliente,dieta,usuario where dieta.idUsuario=usuario.idUsuario and cliente.idCliente=dieta.idCliente and usuario.usuario='" + usuario + "'";
            DataSet ds = new DataSet();
            con.ejecutarSQL(s, "tc", ds);
            return ds;
        }*/




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

        [WebMethod]
        public DataSet mostrarDietasPorCliente(string client)
        {
            clsConexion con = new clsConexion();
            string s;
            s = "select cliente.nombre as Cliente,dieta.nombre as Dieta, date_format(dieta.fechaInicio, '%Y-%m-%d') as Inicio, date_format(dieta.fechaFinal , '%Y-%m-%d') as Final from cliente,dieta where dieta.idCliente=cliente.idCliente and cliente.nombre='" + client + "'";
            DataSet ds = new DataSet();
            con.ejecutarSQL(s, "tc", ds);
            return ds;
        }

        [WebMethod]
        public DataSet mostrarDetallePorDieta(string diet)
        {
            clsConexion con = new clsConexion();
            string s;
            s = "select dieta.nombre as Dieta, comida.descripcion as Comida, dieta_comida.porcion as Porcion, tipo_comida.nombre as TipoComida from comida,dieta,dieta_comida,tipo_comida where dieta_comida.idDieta=dieta.idDieta and dieta_comida.idComida=comida.idComida and comida.idTipoComida=tipo_comida.idTipoComida and dieta.nombre='" + diet + "'";
            DataSet ds = new DataSet();
            con.ejecutarSQL(s, "tc", ds);
            return ds;
        }
        [WebMethod]
        public DataSet mostrarDetallePorCliente(string client)
        {
            clsConexion con = new clsConexion();
            string s;
            s = "select cliente.nombre as Cliente, dieta.nombre as Dieta, comida.descripcion as Comida, dieta_comida.porcion as Porcion, tipo_comida.nombre as TipoComida, date_format(dieta.fechaInicio, '%Y-%m-%d') as Inicio, date_format(dieta.fechaFinal, '%Y-%m-%d') as Final from cliente,comida,dieta,dieta_comida,tipo_comida where dieta.idCliente=cliente.idCliente and dieta_comida.idDieta=dieta.idDieta and dieta_comida.idComida=comida.idComida and comida.idTipoComida=tipo_comida.idTipoComida and cliente.nombre='" + client + "'";
            DataSet ds = new DataSet();
            con.ejecutarSQL(s, "tc", ds);
            return ds;
        }

        [WebMethod]
        public DataSet contarClientePorSexo(string sex)
        {
            clsConexion con = new clsConexion();
            string s;
            s = "select count(sexo) as Sexo_Seleccionado from cliente where sexo='" + sex + "'";
            DataSet ds = new DataSet();
            con.ejecutarSQL(s, "tc", ds);
            return ds;
        }

        [WebMethod]
        public DataSet mostrarClientePorSexo(string sex)
        {
            clsConexion con = new clsConexion();
            string s;
            s = "select * from cliente where sexo='" + sex + "'";
            DataSet ds = new DataSet();
            con.ejecutarSQL(s, "tc", ds);
            return ds;
        }
    }
}
