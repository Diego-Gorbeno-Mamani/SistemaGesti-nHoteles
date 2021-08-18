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
    public class ClsDatosHotel
    {
        public DataTable listar()
        {
            SqlDataReader resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCnx = new SqlConnection();

            try
            {
                SqlCnx = ClsConexion.getIntancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("USP_Hotel_S", SqlCnx);
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

        //Listar empresa
        public DataTable listarEmpresa(int idusuario)
        {
            SqlDataReader resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCnx = new SqlConnection();

            try
            {
                SqlCnx = ClsConexion.getIntancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("USP_Empresa_Listar", SqlCnx);
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

        //metodo buscar
        public DataTable Buscar(string Busqueda)
        {
            SqlDataReader resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCnx = new SqlConnection();
            try
            {
                SqlCnx = ClsConexion.getIntancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("USP_Hotel_S_Buscar", SqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pbusqueda", SqlDbType.VarChar).Value = Busqueda;
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
        public DataTable BuscarEmpresa(string Busqueda,int idusuario)
        {
            SqlDataReader resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCnx = new SqlConnection();
            try
            {
                SqlCnx = ClsConexion.getIntancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("USP_Empresa_S_Buscar", SqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pbusqueda", SqlDbType.VarChar).Value = Busqueda;
                comando.Parameters.Add("@pidusuario", SqlDbType.Int).Value = idusuario;
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
        public string InsertarHotel(ClsEntidadHotel objhotel)
        {
            string Rpta = "";
            SqlConnection sqlCnx = new SqlConnection();
            try
            {
                sqlCnx = ClsConexion.getIntancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("USP_Hotel_I", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pnombre_hotel", SqlDbType.VarChar).Value = objhotel.nombre;
                comando.Parameters.Add("@pdireccion_hotel", SqlDbType.VarChar).Value = objhotel.direccion;
                comando.Parameters.Add("@pciudad", SqlDbType.VarChar).Value = objhotel.ciudad;
                comando.Parameters.Add("@ppais", SqlDbType.VarChar).Value = objhotel.pais;
                comando.Parameters.Add("@pcategoria", SqlDbType.VarChar).Value = objhotel.categoria;
                comando.Parameters.Add("@pimagen", SqlDbType.Image).Value = objhotel.imagen;
                comando.Parameters.Add("@phorario", SqlDbType.VarChar).Value = objhotel.horario;
                comando.Parameters.Add("@pdescripcion", SqlDbType.VarChar).Value = objhotel.descripcion;
                comando.Parameters.Add("@pidusuario", SqlDbType.Int).Value = objhotel.id_usuario;

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
        public string Existe(string Valor)
        {
            string Rpta = "";
            SqlConnection sqlCnx = new SqlConnection();
            try
            {
                sqlCnx = ClsConexion.getIntancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("USP_Hotel_Verificar", sqlCnx);
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
        public DataTable listarid(string nombre)
        {
            SqlDataReader resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCnx = new SqlConnection();

            try
            {
                SqlCnx = ClsConexion.getIntancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("USP_Hotel_Registrado", SqlCnx);
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
        public string ActualizarHotel(ClsEntidadHotel objhotel)
        {
            string Rpta = "";
            SqlConnection sqlCnx = new SqlConnection();
            try
            {
                sqlCnx = ClsConexion.getIntancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("USP_Hotel_U", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pid_hotel", SqlDbType.Int).Value = objhotel.id_hotel;
                comando.Parameters.Add("@pnombre_hotel", SqlDbType.VarChar).Value = objhotel.nombre;
                comando.Parameters.Add("@pdireccion_hotel", SqlDbType.VarChar).Value = objhotel.direccion;
                comando.Parameters.Add("@pciudad", SqlDbType.VarChar).Value = objhotel.ciudad;
                comando.Parameters.Add("@ppais", SqlDbType.VarChar).Value = objhotel.pais;
                comando.Parameters.Add("@pcategoria", SqlDbType.VarChar).Value = objhotel.categoria;
                comando.Parameters.Add("@pimagen", SqlDbType.Image).Value = objhotel.imagen;
                comando.Parameters.Add("@phorario", SqlDbType.VarChar).Value = objhotel.horario;
                comando.Parameters.Add("@pdescripcion", SqlDbType.VarChar).Value = objhotel.descripcion;
                comando.Parameters.Add("@pidusuario", SqlDbType.Int).Value = objhotel.id_usuario;

                sqlCnx.Open();
                Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se Pudo Modificar el Registro";
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
    }
}
