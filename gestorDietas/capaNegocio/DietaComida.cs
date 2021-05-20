using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using capaDatos;

namespace capaNegocio
{
    class DietaComida : clsConexion
    {
        private int idDieta;
        private int idComida;
        private string distribucion;

        public DietaComida()
        {
            idDieta = 0;
            idComida = 0;
            distribucion = "";
        }
        public int IdDieta
        {
            get { return this.idDieta; }
            set { this.idDieta = value; }
        }
        public int IdComida
        {
            get { return this.idComida; }
            set { this.idComida = value; }
        }

        public string Distribucion
        {
            get { return this.distribucion; }
            set { this.distribucion = value; }
        }
        public bool guardar()
        {
            iniciarSP("guardarDetalleVenta");
            parametroInt(idComida, "id_co");
            parametroVarchar(distribucion, "dis", 30);
            if (ejecutarSP() == true) { return true; } else { return false; }
        }
        public bool eliminar()
        {
            iniciarSP("eliminarDietaComida");
            parametroInt(idDieta, "id_d");
            if (ejecutarSP() == true) { return true; } else { return false; }
        }
        public DataTable buscar(int idDieta)
        {
            iniciarSP("buscarDetalleVenta");
            parametroInt(idDieta, "id_d");
            return mostrarData();
        }
    }
}
