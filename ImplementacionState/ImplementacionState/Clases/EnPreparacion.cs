using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionState.Clases
{
    class EnPreparacion : Estado
    {

        public EnPreparacion()
        {
            this.ambito = "Detalle de pedido";
            this.nombre = "En Preparacion";
        }
        public void Cancelar()
        {
            base.cancelar();
        }
        public override void finalizarPreparacion(DateTime fechaHoraFin,List<HistorialEstado> h, DetallePedido d)
        {

            HistorialEstado ultimo = buscarHistActual(h);
            ultimo.horaFin = fechaHoraFin;
            //crearEstado();
            PendienteDeServir pendiente = new PendienteDeServir();
  
            HistorialEstado proximo = new HistorialEstado(DateTime.Now,pendiente,null);
            agregarHistorialEstado(proximo,d);
            d.estado = pendiente;

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

        public void agregarHistorialEstado(HistorialEstado hist, DetallePedido d)
        {
            d.historial.Add(hist);
        }
    }
}
