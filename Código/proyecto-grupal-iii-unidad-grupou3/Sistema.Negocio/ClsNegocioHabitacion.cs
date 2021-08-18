using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Datos;
using Sistema.Entidad;
using System.Data;
using System.Data.SqlClient;

namespace Sistema.Negocio
{
    public class ClsNegocioHabitacion
    {
        public static DataTable CargarTipos()
        {
            ClsDatosHabitaciones objhabitacion = new ClsDatosHabitaciones();
            return objhabitacion.CargarTipos();
        }
        public static string AgregarHabitacion(int idhotel, int idtipo, int cantidad, decimal precio, string disponibilidad, string descripcion)
        {
            ClsDatosHabitaciones objHabitaciones = new ClsDatosHabitaciones();
            ClsEntidadHabitacion objHabi = new ClsEntidadHabitacion();
            objHabi.id_hotel = idhotel;
            objHabi.id_tipoH = idtipo;
            objHabi.cantidad = cantidad;
            objHabi.precio = precio;
            objHabi.descripcion = descripcion;
            objHabi.disponibildad = disponibilidad;
            return objHabitaciones.InsertarHabitacion(objHabi);
        }
        public static DataTable ListarHabitacion(int idhotel)
        {
            ClsDatosHabitaciones obj = new ClsDatosHabitaciones();
            return obj.listarHabitaciones(idhotel);
        }
    }
}
