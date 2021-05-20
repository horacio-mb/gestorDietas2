using capaDatos;
using System;
using System.Collections.Generic;
using System.Data;
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
            parametroFecha(fechaInicio, "fechaI");
            parametroFecha(fechaFinal, "fechaF");
            parametroInt(idCliente, "idCli");
            parametroInt(idUsuario, "idUs");
            if (ejecutarSP() == true) { return true; } else { return false; }
        }
        public bool modificar()
        {
            iniciarSP("modificarDieta");
            parametroInt(IdDieta, "id_d");
            parametroVarchar(nombre, "nom", 30);
            parametroFecha(fechaInicio, "fechaI");
            parametroFecha(fechaFinal, "fechaF");
            parametroInt(idCliente, "idCli");
            parametroInt(idUsuario, "idUs");
            if (ejecutarSP() == true) { return true; } else { return false; }
        }
        public bool eliminar()
        {
            iniciarSP("eliminarDieta");
            parametroInt(idDieta, "id_d");
            if (ejecutarSP() == true) { return true; } else { return false; }
        }
        public DataTable buscar(string buscar)
        {
            iniciarSP("buscarDieta");
            parametroVarchar(buscar, "buscar", 30);
            return mostrarData();
        }
        public string buscarClienteDieta(int Id_Dieta)
        {
            iniciarSP("buscarClienteDieta");
            parametroInt(IdDieta, "IdDieta");
            DataTable cod = new DataTable();
            cod = mostrarData();
            string id = "";
            foreach (DataRow row in cod.Rows)
            {
                id = row["IdDieta"].ToString();
            }
            return id;
        }
    }
}
