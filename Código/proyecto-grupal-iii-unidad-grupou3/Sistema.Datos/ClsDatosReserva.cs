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
    public class ClsDatosReserva
    {
        public string InsertarReserva(ClsEntidadReserva obj)
        {
            string Rpta = "";
            SqlConnection sqlCnx = new SqlConnection();
            try
            {
                sqlCnx = ClsConexion.getIntancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("USP_Reserva_I", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pidreserva", SqlDbType.Int).Value = obj.id_reserva;
                comando.Parameters.Add("@pidusuario", SqlDbType.Int).Value = obj.id_usuario;
                comando.Parameters.Add("@pestado", SqlDbType.VarChar).Value = obj.estado;
                comando.Parameters.Add("@pfecha", SqlDbType.Date).Value = obj.fecha;
 

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
        public DataTable listarReserva(int idusuario)
        {
            SqlDataReader resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCnx = new SqlConnection();

            try
            {
                SqlCnx = ClsConexion.getIntancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("USP_Reserva_Listar", SqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pid_usuario", SqlDbType.VarChar).Value = idusuario;
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
        public string InsertarDetalleReserva(int idHabitacion,int idReserva)
        {
            string Rpta = "";
            SqlConnection sqlCnx = new SqlConnection();
            try
            {
                sqlCnx = ClsConexion.getIntancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("USP_Detalle_Reserva_I", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pidhabitacion", SqlDbType.Int).Value = idHabitacion;
                comando.Parameters.Add("@pidreserva", SqlDbType.Int).Value = idReserva;
              


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

        public DataTable listarReservaEmpresa(int idusuario)
        {
            SqlDataReader resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCnx = new SqlConnection();

            try
            {
                SqlCnx = ClsConexion.getIntancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("USP_ReservaEmpresa_Listar", SqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pid_usuario", SqlDbType.VarChar).Value = idusuario;
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
