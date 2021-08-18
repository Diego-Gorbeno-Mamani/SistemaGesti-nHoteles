using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidad
{
    public class ClsEntidadHabitacion
    {
        public int id_habitacion { get; set; }
        public int id_hotel { get; set; }
        public int id_tipoH { get; set; }
        public int cantidad { get; set; }
        public decimal precio { get; set; }
        public string disponibildad { get; set; }
        public string descripcion { get; set; }
    }
}
