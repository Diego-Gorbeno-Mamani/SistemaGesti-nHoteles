using Sistema.Datos;
using Sistema.Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Negocio
{
    public class ClsNegTipoUsuario
    {
        public static List<ClsTipoUsuario> ListaTipo()
        {
            List<ClsTipoUsuario> Lista = new List<ClsTipoUsuario>();

            SqlConnection sqlCnx = new SqlConnection();

            sqlCnx = ClsConexion.getIntancia().EstablecerConexion();
            sqlCnx.Open();

            SqlCommand comando = new SqlCommand("select top(2) id_tipo_usuario,nombre_tipo_usuario from Tipo_Usuario", sqlCnx);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                ClsTipoUsuario proveedores = new ClsTipoUsuario();
                proveedores.id_tipo_usuario = reader.GetInt32(0);
                proveedores.nombre_tipo_usuario = reader.GetString(1);
                Lista.Add(proveedores);

            }
            sqlCnx.Close();
            return Lista;

        }
    }
}
