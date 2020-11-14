using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionState.Clases
{
    public class HistorialEstado
    {
        public DateTime horaInicio { get; set; }
        public Nullable<DateTime> horaFin { get; set; }
        public Estado estado { get; set; }

        public HistorialEstado(DateTime horaInnicio, Estado estado, Nullable<DateTime> horaFin = null)
        {
            this.horaInicio = horaInnicio;
            this.horaFin = horaFin;
            this.estado = estado;
        }
        public bool obtenerUltimoEstado() 
        {
            if (horaFin == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
