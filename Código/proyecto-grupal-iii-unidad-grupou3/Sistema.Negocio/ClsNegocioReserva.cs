using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Datos;
using Sistema.Entidad;
using System.Data;

namespace Sistema.Negocio
{
    public class ClsNegocioReserva
    {
        public static string InsertarReserva(int idreserva, int idusuaripo, string estado, DateTime fecha)
        {
            ClsDatosReserva obj = new ClsDatosReserva();

            ClsEntidadReserva objUsuarioE = new ClsEntidadReserva();
            objUsuarioE.id_reserva = idreserva;
            objUsuarioE.id_usuario = idusuaripo;
            objUsuarioE.estado = estado;
            objUsuarioE.fecha = fecha;

            return obj.InsertarReserva(objUsuarioE);

        }
        public static DataTable ListarReserva(int idusuario)
        {
            ClsDatosReserva obj = new ClsDatosReserva();
            return obj.listarReserva(idusuario);
        }
        public static string InsertarDetalleReserva(int idHabitacion, int idReserva)
        {
            ClsDatosReserva obj = new ClsDatosReserva();

            return obj.InsertarDetalleReserva(idHabitacion, idReserva);

        }
        public static DataTable ListarReservaEmpresa(int idusuario)
        {
            ClsDatosReserva obj = new ClsDatosReserva();
            return obj.listarReservaEmpresa(idusuario);
        }
    }
}
