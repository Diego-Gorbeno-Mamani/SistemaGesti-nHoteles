using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Entidad;
using System.Data;
using System.Data.SqlClient;

namespace Sistema.Datos
{
    public class ClsDatosUsuario
    {
        //procedimiento insertar
        public string InsertarUsuario(ClsEntidadUsuario objusuario)
        {
            string Rpta = "";
            SqlConnection sqlCnx = new SqlConnection();
            try
            {
                sqlCnx = ClsConexion.getIntancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("USP_Usuario_I", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@ptipo_usuario", SqlDbType.Int).Value = objusuario.id_tipo_usuario;
                comando.Parameters.Add("@ptipo_documento", SqlDbType.Int).Value = objusuario.id_tipo_documento;
                comando.Parameters.Add("@pnombre", SqlDbType.VarChar).Value = objusuario.nombre_usuario;
                comando.Parameters.Add("@papellido", SqlDbType.VarChar).Value = objusuario.apellido_usuario;
                comando.Parameters.Add("@ptelefono", SqlDbType.Char).Value = objusuario.telefono_usuario;
                comando.Parameters.Add("@pdireccion", SqlDbType.VarChar).Value = objusuario.direccion_usuario;
                comando.Parameters.Add("@pclave", SqlDbType.Char).Value = objusuario.clave_usuario;
                comando.Parameters.Add("@pnumero_documento", SqlDbType.VarChar).Value = objusuario.numero_documento;
                sqlCnx.Open();
                Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se Pudo Agregar el Registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (sqlCnx.State == ConnectionState.Open)
                {
                    sqlCnx.Close();
                }
            }
            return Rpta;
        }
        //procedimiento loguear
        public DataTable Loguear(string usuario, string password)
        {
            SqlDataReader resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlCnx = new SqlConnection();
            try
            {
                sqlCnx = ClsConexion.getIntancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("USP_Usuario_Loguear", sqlCnx);

                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pnombre", SqlDbType.VarChar).Value = usuario;
                comando.Parameters.Add("@pclave", SqlDbType.VarChar).Value = password;
                sqlCnx.Open();
                resultado = comando.ExecuteReader();
                Tabla.Load(resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCnx.State == ConnectionState.Open)
                {
                    sqlCnx.Close();
                }
            }
        }
        //verificar
        public string Existe(string Valor)
        {
            string Rpta = "";
            SqlConnection sqlCnx = new SqlConnection();
            try
            {
                sqlCnx = ClsConexion.getIntancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("USP_Usuario_Verificar", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pvalor", SqlDbType.VarChar).Value = Valor;
                SqlParameter ParExiste = new SqlParameter();
                ParExiste.ParameterName = "@existe";
                ParExiste.SqlDbType = SqlDbType.Int;
                ParExiste.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ParExiste);
                sqlCnx.Open();
                comando.ExecuteNonQuery();
                Rpta = Convert.ToString(ParExiste.Value);
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (sqlCnx.State == ConnectionState.Open)
                {
                    sqlCnx.Close();
                }
            }
            return Rpta;
        }
        public DataTable listar(string nombre)
        {
            SqlDataReader resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCnx = new SqlConnection();

            try
            {
                SqlCnx = ClsConexion.getIntancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("USP_Usuario_Logueado", SqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pnombre", SqlDbType.VarChar).Value = nombre;
                SqlCnx.Open();
                resultado = comando.ExecuteReader();
                Tabla.Load(resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCnx.State == ConnectionState.Open) SqlCnx.Close();
            }
        }
    }
}
