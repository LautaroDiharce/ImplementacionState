using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionState.Clases
{
    public class DetallePedido
    {
        public int idDetalle { get; set; }
        public int cantidad { get; set; }
        public List<HistorialEstado> historial { get; set; }
        public Pedido pedido { get; set; }
        public Menu menu { get; set; }
        public ProductoDeCarta producto { get; set; }
        public Estado estado { get; set; }

        public double tiempoEsperaEnMin { get; set; }

        public DetallePedido(int idDetalle,int cantidad, List<HistorialEstado> historial, Pedido pedido, Estado estado, double tiempoEsperaEnMin, Menu menu = null, ProductoDeCarta producto=null)
        {
            this.idDetalle = idDetalle;
            this.cantidad = cantidad;
            this.historial = historial;
            this.pedido = pedido;
            this.menu = menu;
            this.producto = producto;
            this.estado = estado;
            this.tiempoEsperaEnMin = tiempoEsperaEnMin;
        }

        public string mostrarNombreProducto()
        {
            return producto.mostrarProducto();
        }

        public string mostrarNombreMenu()
        {
            return menu.nombre;
        }

        public string mostrarMesa()
        {
            return pedido.mostrarMesa();
        }

        public void finalizarPreparacion()
        {
            estado.finalizarPreparacion(DateTime.Now, historial,this);
        }
        public void notificar()
        {
            estado.notificar(DateTime.Now, historial,this);
        }

        internal string MostrarMozo()
        {
            return pedido.mostrarMozo();
        }

        internal TimeSpan calcularEspera()
        {
            DateTime inicio = DateTime.MinValue;
            DateTime actual = DateTime.Now;
            foreach (var hist in historial)
            {
                if (hist.obtenerUltimoEstado())
                {

                    inicio = hist.horaInicio;
                }
                
            }
            TimeSpan espera = actual - inicio;


            return espera;
        }
    }
}
