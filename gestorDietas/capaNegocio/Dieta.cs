using capaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    public class Dieta : clsConexion
    {
        private int idDieta;
        private string nombre;
        private DateTime fechaInicio;
        private DateTime fechaFinal;
        private int idCliente;
        private int idUsuario;

        public Dieta()
        {
            idDieta = 0;
            nombre = "";
            fechaInicio = DateTime.Today.Date;
            fechaFinal = DateTime.Today.Date;
            idCliente = 0;
            idUsuario = 0;
        }
        public int IdDieta
        {
            get { return this.idDieta; }
            set { this.idDieta = value; }
        }
        public DateTime FechaInicio
        {
            get { return this.fechaInicio; }
            set { this.fechaInicio = value; }
        }
        public DateTime FechaFinal
        {
            get { return this.fechaFinal; }
            set { this.fechaFinal = value; }
        }
        public int IdCliente
        {
            get { return this.idCliente; }
            set { this.idCliente = value; }
        }
        public int IdUsuario
        {
            get { return this.idUsuario; }
            set { this.idUsuario = value; }
        }
        public bool guardar()
        {
            iniciarSP("guardarDieta");
            parametroVarchar(nombre, "nom", 30);
            parametroDecimal(monto, "mont");
            parametroInt(id_cliente, "id_cli");
            if (ejecutarSP() == true) { return true; } else { return false; }
        }
    }
}
