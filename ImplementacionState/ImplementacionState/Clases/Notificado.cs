using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionState.Clases
{
    public class Notificado : Estado
    {
        public Notificado()
        {
            this.ambito = "Detalle de pedido";
            this.nombre = "Notificado";
        }
    }
}
