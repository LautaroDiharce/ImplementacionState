using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionState.Clases
{
    class PendienteDeServir : Estado
    {

        public PendienteDeServir()
        {
            this.ambito = "Detalle de pedido";
            this.nombre = "Pendiente de servir";
        }
        public override void notificar(DateTime horafin, List<HistorialEstado> h,DetallePedido d)
        {
            HistorialEstado ultimo = buscarHistActual(h);
            ultimo.horaFin = DateTime.Now;
            Notificado notificado = new Notificado();

            HistorialEstado prox = new HistorialEstado(DateTime.Now, notificado,null);
            d.historial.Add(prox);
            d.estado = notificado;


        }
        private HistorialEstado buscarHistActual(List<HistorialEstado> listaHist)
        {
            HistorialEstado ultimo = null;
            foreach (var i in listaHist)
            {
                if (i.horaFin == null)
                {
                    ultimo = i;
                }
            }
            return ultimo;
        }
    }
}
