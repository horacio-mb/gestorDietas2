using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;

namespace capaNegocio
{
    public class Comida : clsConexion
    {
        private int idComida;
        private string descripcion;
        private int idTipoComida;

        public Comida()
        {
            idComida = 0;
            descripcion = "";
            idTipoComida = 0;
        }

        public int id_Comida
        {
            get { return this.idComida; }
            set { this.idComida = value; }
        }

        public string Descripcion
        {
            get { return this.descripcion; }
            set { this.descripcion = value; }

        }

        public int id_TipoComida
        {
            get { return this.idTipoComida; }
            set { this.idTipoComida = value; }
        }

        public bool guardar()
        {
            iniciarSP("guardarComida");
            parametroVarchar(descripcion, "des", 30);
            parametroInt(idTipoComida, "id_tc");
            if (ejecutarSP() == true) { return true; }
            else { return false; }
        }

        public bool modificar()
        {
            iniciarSP("modificarComida");
            parametroInt(idComida, "id_com");
            parametroVarchar(descripcion, "des", 30);
            parametroInt(idTipoComida, "id_tc");
            if (ejecutarSP() == true) { return true; }
            else { return false; }
        }

        public bool eliminar()
        {
            iniciarSP("eliminarComida");
            parametroInt(idComida, "id_com");
            if (ejecutarSP() == true) { return true; }
            else { return false; }
        }

        public DataTable buscar()
        {
            iniciarSP("buscarComida");
            parametroVarchar(descripcion, "buscar", 40);
            return mostrarData();
        }
    }


}
