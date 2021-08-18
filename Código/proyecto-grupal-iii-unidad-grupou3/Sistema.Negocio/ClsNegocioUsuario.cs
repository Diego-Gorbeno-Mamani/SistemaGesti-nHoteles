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
    public class ClsNegocioUsuario
    {
        public static string InsertarUsuario(int tipousuario,int tipodocumento,string nombre,string apellido,string telefono,string direccion,string clave,string numerodocumento)
        {
             ClsDatosUsuario objUsuarioD = new ClsDatosUsuario();
            string Existe = objUsuarioD.Existe(numerodocumento);
            if (Existe.Equals("1"))
            {
                return "El usuario ya Existe en la Base de Datos";
            }
            else
            {
                 ClsEntidadUsuario objUsuarioE = new ClsEntidadUsuario();
                objUsuarioE.id_tipo_usuario = tipousuario;
                objUsuarioE.id_tipo_documento = tipodocumento;
                objUsuarioE.nombre_usuario = nombre;
                objUsuarioE.apellido_usuario = apellido;
                objUsuarioE.telefono_usuario = telefono;
                objUsuarioE.direccion_usuario = direccion;
                objUsuarioE.clave_usuario = clave;
                objUsuarioE.numero_documento= numerodocumento;
                return objUsuarioD.InsertarUsuario(objUsuarioE);
            }
        }
        public static DataTable LoguearUsuario(string nombre, string clave)
        {
            ClsDatosUsuario objusu = new ClsDatosUsuario();
            return objusu.Loguear(nombre, clave);
        }
        public static DataTable DatosLogueado(string nombre)
        {
            ClsDatosUsuario objusu = new ClsDatosUsuario();
            return objusu.listar(nombre);
        }
    }
}
