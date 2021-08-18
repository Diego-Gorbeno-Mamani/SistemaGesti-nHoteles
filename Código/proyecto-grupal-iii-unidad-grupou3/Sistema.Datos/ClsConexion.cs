using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Sistema.Datos
{
    public class ClsConexion
    {
        private string BD;
        private string Server;
        private string User;
        private string Clave;
        private bool Autenticacion;
        private static ClsConexion cnx = null;
        private ClsConexion()
        {
            this.BD = "db_sistema_gestion_hoteles";
            this.Server = "serverappprueba.database.windows.net";//Nombre de equipo//IP/LOCALHOST
            this.User = "administrador";
            this.Clave = "JEDIES-123";
            this.Autenticacion = false;
        }
        public SqlConnection EstablecerConexion()
        {
            SqlConnection cadena = new SqlConnection();
            try
            {
                cadena.ConnectionString = "Server=" + this.Server + ";" + "Database=" + this.BD + ";";
                if (this.Autenticacion)//seguridad de windows true
                {
                    cadena.ConnectionString = cadena.ConnectionString + "Integrated Security = SSPI";
                }
                else//seguridad sql
                {
                    cadena.ConnectionString = cadena.ConnectionString + "User Id=" + this.User + ";" + "Password=" + this.Clave;
                }
            }
            catch (Exception ex)
            {
                cadena = null;
                throw ex;
            }
            return cadena;
        }
        public static ClsConexion getIntancia()
        {
            if (cnx == null)
            {
                cnx = new ClsConexion();
            }
            return cnx;
        }
    }
}
