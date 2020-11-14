using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionState.Clases
{
    public class PendienteDePreparacion : Estado
    {
        public PendienteDePreparacion()
        {
            this.ambito = "Detalle de pedido";
            this.nombre = "Pendiente de preparacion";
        }
    }
}
