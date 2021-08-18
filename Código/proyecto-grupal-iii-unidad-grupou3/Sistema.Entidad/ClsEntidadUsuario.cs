using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidad
{
    public class ClsEntidadUsuario
    {
        public int id_usuario { get; set; }
        public int id_tipo_documento { get; set; }
        public int id_tipo_usuario { get; set; } 
        public string nombre_usuario { get; set; }
        public string apellido_usuario { get; set; }
        public string telefono_usuario { get; set; }
        public string direccion_usuario { get; set; }
        public string clave_usuario { get; set; }
        public string numero_documento { get; set; }

    }
}
