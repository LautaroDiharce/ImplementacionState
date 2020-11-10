using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionState.Clases
{
    public class Pedido
    {
        public List<HistorialEstado> historial { get; set; }
        public List<DetallePedido> detalles { get; set; }
        public Mesa mesa { get; set; }

        public int nroPedido { get; set; }

        public Pedido(List<HistorialEstado> historial, List<DetallePedido> detalles, Mesa mesa, int nroPedido)
        {
            this.historial = historial;
            this.detalles = detalles;
            this.mesa = mesa;
            this.nroPedido = nroPedido;
        }
    }
}
