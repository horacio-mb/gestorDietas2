using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using capaDatos;

namespace capaNegocio
{
    public class Usuario : clsConexion
    {
        private int idUsuario;
        private string usuario;
        private string correo;
        private string contrasena;
        private string nombre;
        private string materno;
        private string paterno;
        private string cargo;

        public Usuario()
        {
            idUsuario = 0;
            usuario = "";
            correo = "";
            contrasena = "";
            nombre = "";
            paterno = "";
            materno = "";
            cargo = "";
        }
        public int Idusuario
        {
            get { return this.idUsuario; }
            set { this.idUsuario = value; }
        }

        public string Usuario1
        {
            get { return this.usuario; }
            set { this.usuario = value; }
        }

        public string Correo
        {
            get { return this.correo; }
            set { this.correo = value; }
        }

        public string Contraseña
        {
            get { return this.contrasena; }
            set { this.contrasena = value; }
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

        public string Cargo
        {
            get { return this.cargo; }
            set { this.cargo = value; }
        }
        public bool guardar()
        {
            iniciarSP("guardarUsuario");
            parametroVarchar(usuario, "usu", 30);
            parametroVarchar(correo, "cor", 30);
            parametroVarchar(contrasena, "con", 150);
            parametroVarchar(nombre, "nom", 30);
            parametroVarchar(paterno, "pat", 30);
            parametroVarchar(materno, "mat", 30);
            parametroVarchar(cargo, "car", 30);
            if (ejecutarSP() == true) { return true; } else { return false; }
        }

        public bool modificar()
        {
            iniciarSP("modificarUsuario");
            parametroInt(idUsuario, "id");
            parametroVarchar(usuario, "usu", 30);
            parametroVarchar(correo, "cor", 30);
            parametroVarchar(contrasena, "con", 150);
            parametroVarchar(nombre, "nom", 30);
            parametroVarchar(paterno, "pat", 30);
            parametroVarchar(materno, "mat", 30);
            parametroVarchar(cargo, "car", 30);
            if (ejecutarSP() == true) { return true; } else { return false; }
        }
        public bool eliminar()
        {
            iniciarSP("eliminarUsuario");
            parametroInt(idUsuario, "id");
            if (ejecutarSP() == true) { return true; } else { return false; }
        }
        public DataTable buscar()
        {
            iniciarSP("buscarUsuario");
            parametroVarchar(cargo, "buscar", 30);
            return mostrarData();
        }
    }


}