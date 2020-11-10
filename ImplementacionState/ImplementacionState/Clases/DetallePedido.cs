using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionState.Clases
{
    public class DetallePedido
    {
        public int cantidad { get; set; }
        public List<HistorialEstado> historial { get; set; }
        public Pedido pedido { get; set; }
        public Menu menu { get; set; }
        public ProductoDeCarta producto { get; set; }
        public Estado estado { get; set; }


        public DetallePedido(int cantidad, List<HistorialEstado> historial, Pedido pedido, Menu menu, ProductoDeCarta producto, Estado estado)
        {
            this.cantidad = cantidad;
            this.historial = historial;
            this.pedido = pedido;
            this.menu = menu;
            this.producto = producto;
            this.estado = estado;

        }
    }
}
