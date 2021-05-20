using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace capaDatos
{
    public class clsConexion
    {
        private String servidor;
        private String basedatos;
        private String usuario;
        private String contrasena;
        private MySqlCommand cmdSP;

        public clsConexion()
        { //constructor
            this.servidor = "localhost";
            this.usuario = "root";
            this.contrasena = "Passw0rd";
            this.basedatos = "bdgestordietas";
            this.cmdSP = new MySqlCommand();
        }

        public MySqlConnection conectar()
        {
            MySqlConnection cnx = new MySqlConnection();
            cnx.ConnectionString = "Data Source =" + this.servidor + "; User ID=" + this.usuario + "; Password=" + this.contrasena + "; Initial Catalog= " + this.basedatos;
            cnx.Open();
            return cnx;
        }

        public void desconectar()
        {
            MySqlConnection cnx = this.conectar();
            cnx.Close();
        }

        public void iniciarSP(String sp)
        {
            //procedimiento almacenado
            cmdSP.Connection = conectar();
            cmdSP.CommandType = CommandType.StoredProcedure;
            cmdSP.CommandText = sp;
        }
        public void parametroInt(int valor, string param)
        {
            MySqlParameter Par = new MySqlParameter();
            Par.ParameterName = param;
            Par.MySqlDbType = MySqlDbType.Int32;
            Par.Value = valor;
            cmdSP.Parameters.Add(Par);
        }

        public void parametroDecimal(decimal valor, string param)
        {
            MySqlParameter Par = new MySqlParameter();
            Par.ParameterName = param;
            Par.MySqlDbType = MySqlDbType.Decimal;
            Par.Value = valor;
            cmdSP.Parameters.Add(Par);
        }

        public void parametroVarchar(string valor, string param, int dimension)
        {
            MySqlParameter Par = new MySqlParameter();
            Par.ParameterName = param;
            Par.MySqlDbType = MySqlDbType.VarChar;
            Par.Size = dimension;
            Par.Value = valor;
            cmdSP.Parameters.Add(Par);
        }
        public void parametroFecha(DateTime valor, string param)
        {
            MySqlParameter Par = new MySqlParameter();
            Par.ParameterName = param;
            Par.MySqlDbType = MySqlDbType.DateTime;
            Par.Value = valor;
            cmdSP.Parameters.Add(Par);
        }

        public DataTable mostrarData()
        {
            DataTable DtResultado = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(this.cmdSP);
            da.Fill(DtResultado);
            this.desconectar();
            return DtResultado;
        }

        public void AddParametro(String param, String valor)
        {
            MySqlParameter par = new MySqlParameter();
            par.ParameterName = param;
            par.Value = valor;
            cmdSP.Parameters.Add(par);
        }

        public void ejecutarSP()
        {
            MySqlDataReader spResult;
            cmdSP.Prepare();
            spResult = cmdSP.ExecuteReader();
        }

        public void ejecutarSQL(String s, String nTable, DataSet ds)
        {
            MySqlDataAdapter MysqlAdapter;
            MysqlAdapter = new MySqlDataAdapter(s, conectar());
            MysqlAdapter.Fill(ds, nTable);
            desconectar();
        }

    }
}
