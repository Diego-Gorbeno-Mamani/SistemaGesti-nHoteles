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
    public class ClsNegTipoDocumento
    {
        public static List<ClsTipoDocumento> ListaTipoDocumento()
        {
            List<ClsTipoDocumento> Lista = new List<ClsTipoDocumento>();

            SqlConnection sqlCnx = new SqlConnection();

            sqlCnx = ClsConexion.getIntancia().EstablecerConexion();
            sqlCnx.Open();

            SqlCommand comando = new SqlCommand("select id_tipo_documento,nombre_tipo_documento from Tipo_Documento", sqlCnx);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                ClsTipoDocumento proveedores = new ClsTipoDocumento();
                proveedores.id_tipo_documento = reader.GetInt32(0);
                proveedores.nombre_tipo_documento = reader.GetString(1);
                Lista.Add(proveedores);
            }
            sqlCnx.Close();
            return Lista;

        }
    }
}
