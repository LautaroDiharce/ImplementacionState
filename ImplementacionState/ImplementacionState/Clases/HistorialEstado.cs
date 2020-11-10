using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionState.Clases
{
    public class HistorialEstado
    {
        public DateTime horaInnicio { get; set; }
        public DateTime horaFin { get; set; }
        public Estado estado { get; set; }

        public HistorialEstado(DateTime horaInnicio, DateTime horaFin, Estado estado)
        {
            this.horaInnicio = horaInnicio;
            this.horaFin = horaFin;
            this.estado = estado;
        }
    }
}
