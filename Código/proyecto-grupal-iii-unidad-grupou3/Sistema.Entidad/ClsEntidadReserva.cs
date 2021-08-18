using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidad
{
    public class ClsEntidadReserva
    {
        public int id_reserva { get; set; }
        public int id_usuario { get; set; }
        public string estado { get; set; }
        public DateTime fecha { get; set; }
    }
}
