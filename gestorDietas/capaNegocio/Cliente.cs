using capaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    class Cliente : clsConexion
    {
        private int id;
        private string nombre;
        private string paterno;
        private string materno;
        private DateTime fecha_nacimiento;
        private string correo;
        private string telefono;
        private string sexo;


        public Cliente()
        {
            id = 0;
            nombre = "";
            paterno = "";
            materno = "";
            fecha_nacimiento = DateTime.Today.Date;
            correo = "";
            telefono = "";
            sexo = "";
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string Paterno
        {
            get { return this.paterno; }
            set { this.paterno = value; }
        }

        public string Materno
        {
            get { return this.materno; }
            set { this.materno = value; }
        }

        public DateTime Fecha_nacimiento
        {
            get { return this.fecha_nacimiento; }
            set { this.fecha_nacimiento = value; }
        }

        public string Correo
        {
            get { return this.correo; }
            set { this.correo = value; }
        }

        public string Telefono
        {
            get { return this.telefono; }
            set { this.telefono = value; }
        }

        public string Sexo
        {
            get { return this.sexo; }
            set { this.sexo = value; }
        }



        ///Metodos CRUD
        public bool guardar()
        {
            iniciarSP("guardarCliente");
            parametroVarchar(nombre, "nom", 30);
            parametroVarchar(paterno, "pat", 30);
            parametroVarchar(materno, "mat", 30);
            parametroFecha(fecha_nacimiento, "fec");
            parametroVarchar(correo, "cor", 30);
            parametroVarchar(telefono, "tel", 30);
            parametroVarchar(sexo, "sex", 1);
            if (ejecutarSP() == true) { return true; } else { return false; }
        }

        public bool modificar()
        {
            iniciarSP("modificarCliente");
            parametroInt(id, "id");
            parametroVarchar(nombre, "nom", 30);
            parametroVarchar(paterno, "pat", 30);
            parametroVarchar(materno, "mat", 30);
            parametroFecha(fecha_nacimiento, "fec");
            parametroVarchar(correo, "cor", 30);
            parametroVarchar(telefono, "tel", 30);
            parametroVarchar(sexo, "sex", 1);
            if (ejecutarSP() == true) { return true; } else { return false; }
        }

        public bool eliminar()
        {
            iniciarSP("eliminarCliente");
            parametroInt(id, "id");
            if (ejecutarSP() == true) { return true; } else { return false; }
        }

        public DataTable buscar()
        {
            iniciarSP("buscarCliente");
            parametroVarchar(nombre, "buscar", 30);
            return mostrarData();
        }
    }
}
