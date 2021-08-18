using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Entidad;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Sistema.Datos
{
    public class ClsDatosHabitaciones
    {
        public DataTable CargarTipos()
        {
            SqlDataReader resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCnx = new SqlConnection();

            try
            {
                SqlCnx = ClsConexion.getIntancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("USP_CargarComboBox_Habitaciones_tipo", SqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
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
        public string InsertarHabitacion(ClsEntidadHabitacion objhabi)
        {
            string Rpta = "";
            SqlConnection sqlCnx = new SqlConnection();
            try
            {
                sqlCnx = ClsConexion.getIntancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("USP_Habitacion_I", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pid_hotel", SqlDbType.Int).Value = objhabi.id_hotel;
                comando.Parameters.Add("@pid_tipo_habitacion", SqlDbType.Int).Value = objhabi.id_tipoH;
                comando.Parameters.Add("@pcantidad", SqlDbType.Int).Value = objhabi.cantidad;
                comando.Parameters.Add("@pprecio", SqlDbType.Float).Value = objhabi.precio;
                comando.Parameters.Add("@pdisponibilidad", SqlDbType.VarChar).Value = objhabi.disponibildad;
                comando.Parameters.Add("@pdescripcion", SqlDbType.VarChar).Value = objhabi.descripcion;
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
        public DataTable listarHabitaciones(int idhotel)
        {
            SqlDataReader resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCnx = new SqlConnection();

            try
            {
                SqlCnx = ClsConexion.getIntancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("USP_Habitacion_S", SqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pidhotel", SqlDbType.Int).Value = idhotel;
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
