using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionState.Clases
{
    public class Estado
    {
        protected DetallePedido detalle;
        protected Pedido pedido;
        protected string ambito { get; set; }
        protected string nombre { get; set; }

        public DetallePedido Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }

        public Pedido Pedido
        {
            get { return pedido; }
            set { pedido = value; }
        }
        public string Ambito
        {
            get { return ambito; }
            set { ambito = value; }
        }


        public virtual void preparar() { }
        public virtual void cancelar()
        {

        }
        public virtual void servir() { }
        public virtual void crearNuevoHistorial() { }
        public virtual void notificar(DateTime horafin, List<HistorialEstado> h,DetallePedido d) { }
        public virtual void finalizarPreparacion(DateTime fechaHoraFin, List<HistorialEstado> h, DetallePedido d)
        {

        }
        public virtual void crearEstado() { }
        public virtual void finalizar() { }

    }

}
