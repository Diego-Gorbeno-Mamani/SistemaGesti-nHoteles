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
    public class ClsNegocioHotel
    {
        //metodo listar
        public static DataTable Listar()
        {
            ClsDatosHotel objhotel = new ClsDatosHotel();
            return objhotel.listar();
        }
        public static DataTable DatosIdHotel(string nombre)
        {
            ClsDatosHotel objhotel = new ClsDatosHotel();
            return objhotel.listarid(nombre);
        }

        //metodo listar empresa
        public static DataTable ListarEmpresa(int idusuario)
        {
            ClsDatosHotel objhotel = new ClsDatosHotel();
            return objhotel.listarEmpresa(idusuario);
        }

        //buscar
        public static DataTable Buscar(string busqueda)
        {
            ClsDatosHotel objhotel = new ClsDatosHotel();
            return objhotel.Buscar(busqueda);
        }
        public static DataTable BuscarEmpresa(string busqueda,int idusuario)
        {
            ClsDatosHotel objhotel = new ClsDatosHotel();
            return objhotel.BuscarEmpresa(busqueda,idusuario);
        }
        public static string AgregarHotel(string nombre, string direccion, string ciudad, string pais, string categoria, byte[] foto, string horario, string descripcion,int usuario)
        {
            ClsDatosHotel objHotelD = new ClsDatosHotel();
            string Existe = objHotelD.Existe(nombre);
            if (Existe.Equals("1"))
            {
                return "El Hotel ya Existe en la Base de Datos";
            }
            else
            {
                ClsEntidadHotel objHotelE = new ClsEntidadHotel();               
                objHotelE.nombre = nombre;
                objHotelE.direccion = direccion;
                objHotelE.ciudad = ciudad;
                objHotelE.pais = pais;
                objHotelE.categoria = categoria;
                objHotelE.imagen = foto;
                objHotelE.horario = horario;
                objHotelE.descripcion = descripcion;
                objHotelE.id_usuario = usuario;

                return objHotelD.InsertarHotel(objHotelE);
            }
        }
        public static string ActualizarHotel(int idhotel, string nombre, string direccion, string ciudad, string pais, string categoria, byte[] foto, string horario, string descripcion, int usuario)
        {
            ClsDatosHotel objHotelD = new ClsDatosHotel();
            string Existe = objHotelD.Existe(nombre);

            if (Existe.Equals("1"))
            {
                return "El Hotel ya Existe en la Base de Datos";
            }
            else
            {
                ClsEntidadHotel objHotelE = new ClsEntidadHotel();
                objHotelE.id_hotel = idhotel;
                objHotelE.nombre = nombre;
                objHotelE.direccion = direccion;
                objHotelE.ciudad = ciudad;
                objHotelE.pais = pais;
                objHotelE.categoria = categoria;
                objHotelE.imagen = foto;
                objHotelE.horario = horario;
                objHotelE.descripcion = descripcion;
                objHotelE.id_usuario = usuario;

                return objHotelD.ActualizarHotel(objHotelE);
            }

        }
    }
}
