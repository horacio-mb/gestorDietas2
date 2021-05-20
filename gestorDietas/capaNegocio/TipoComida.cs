using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;

namespace capaNegocio
{
    public class TipoComida : clsConexion
    {

        private int idTipoComida;
        private string nombre;

        public TipoComida()
        {
            idTipoComida = 0;
            nombre = "";

        }

        public int id_TipoComida
        {
            get { return this.idTipoComida; }
            set { this.idTipoComida = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public bool guardar()
        {
            iniciarSP("guardarTipoComida");
            parametroVarchar(Nombre, "buscar", 40);
            if (ejecutarSP() == true) { return true; }
            else { return false; }
        }

        public DataTable buscar()
        {
            iniciarSP("buscarTipoComida");
            parametroVarchar(Nombre, "buscar", 40);
            return mostrarData();
        }

        public DataTable listarTipoComida()
        {
            iniciarSP("listarTipoComida");
            return mostrarData();
        }

        public bool modificar()
        {
            iniciarSP("modificarTipoComida");
            parametroInt(idTipoComida, "id_tc");
            parametroVarchar(Nombre, "nom", 40);
            if (ejecutarSP() == true) { return true; }
            else { return false; }
        }

        public bool eliminar()
        {
            iniciarSP("eliminarTipoComida");
            parametroInt(idTipoComida, "id_tc");
            if (ejecutarSP() == true) { return true; }
            else { return false; }
        }
    }
}