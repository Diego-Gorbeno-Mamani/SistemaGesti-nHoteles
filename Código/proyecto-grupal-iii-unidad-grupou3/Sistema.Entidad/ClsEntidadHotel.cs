using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidad
{
    public class ClsEntidadHotel
    {
        public int id_hotel { get; set; }
        public int id_usuario { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string ciudad { get; set; }
        public string pais { get; set; }
        public string categoria { get; set; }
        public byte[] imagen { get; set; }
        public string horario { get; set; }
        public string descripcion { get; set; }
        
    }
}
