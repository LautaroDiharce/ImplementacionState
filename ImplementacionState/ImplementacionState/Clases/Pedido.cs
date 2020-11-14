using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionState.Clases
{
    public class Pedido
    {
        public Mesa mesa { get; set; }

        public int nroPedido { get; set; }

        public Pedido(Mesa mesa, int nroPedido)
        {

            this.mesa = mesa;
            this.nroPedido = nroPedido;
        }

        public string mostrarMesa()
        {
            return mesa.numero.ToString();
        }

        internal string mostrarMozo()
        {
            return mesa.mozo;
        }
    }
}
