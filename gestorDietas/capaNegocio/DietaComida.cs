using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using capaDatos;

namespace capaNegocio
{
    public class DietaComida : clsConexion
    {
        private int idDieta;
        private int idComida;
        private int porcion;

        public DietaComida()
        {
            idDieta = 0;
            idComida = 0;
            porcion = 0;
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

        public int Porcion
        {
            get { return this.porcion; }
            set { this.porcion = value; }
        }
        public bool guardar()
        {
            iniciarSP("guardarDietaComida");
            parametroInt(idComida, "id_co");
            parametroInt(porcion, "dis");
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
            iniciarSP("buscarDietaComida");
            parametroInt(idDieta, "id_d");
            return mostrarData();
        }
    }
}
