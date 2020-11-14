using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImplementacionState.UIs;

namespace ImplementacionState.Clases
{
    public class GestorFinalizarPreparacionPedido
    {

        public List<DetallePedido> cargarObjetos()
        {
            Mesa m1 = new Mesa(6, "Rectangulo", 1,"Jhon Doe");
            Mesa m2 = new Mesa(8, "Rectangulo", 2, "Juan Perez");
            Mesa m3 = new Mesa(4, "Cuadrado", 3, "David Diaz");

            Producto prod1 = new Producto("Hamburguesa", 150);
            Producto prod2 = new Producto("Pizza", 250);
            Producto prod3 = new Producto("Cerveza", 100);
            Producto prod4 = new Producto("Papas Fritas", 125);

            ProductoDeCarta pdc1 = new ProductoDeCarta(prod1);
            ProductoDeCarta pdc2 = new ProductoDeCarta(prod2);
            ProductoDeCarta pdc3 = new ProductoDeCarta(prod3);
            ProductoDeCarta pdc4 = new ProductoDeCarta(prod4);

            Menu menu1 = new Menu("Menu Ejecutivo", 400);
            Menu menu2 = new Menu("Menu Estudiantil", 300);

            EnPreparacion ed1 = new EnPreparacion();
            EnPreparacion ed2 = new EnPreparacion();
            Cancelado ed3 = new Cancelado();
            Cancelado ed4 = new Cancelado();
            Notificado ed5 = new Notificado();
            EnPreparacion ed6 = new EnPreparacion();
            EnPreparacion ed7 = new EnPreparacion();
            PendienteDePreparacion ea1 = new PendienteDePreparacion();
            PendienteDePreparacion ea2 = new PendienteDePreparacion();
            PendienteDePreparacion ea3 = new PendienteDePreparacion();
            PendienteDePreparacion ea4 = new PendienteDePreparacion();

            Pedido p1 = new Pedido(m1, 1);
            Pedido p2 = new Pedido(m2, 2);
            Pedido p3 = new Pedido(m3, 3);
            //DateFormat = {11/13/2020 12:00:00 AM}

            HistorialEstado h4 = new HistorialEstado(DateTime.Parse("10/13/2020 10:30:00 pm"), ea1, DateTime.Parse("11/13/2020 11:30:00 pm"));
            HistorialEstado h5 = new HistorialEstado(DateTime.Parse("10/13/2020 10:00:00 pm"), ea2, DateTime.Parse("11/13/2020 11:30:00 pm"));
            HistorialEstado h6 = new HistorialEstado(DateTime.Parse("10/13/2020 10:30:00 pm"), ea3, DateTime.Parse("11/13/2020 11:30:00 pm"));
            HistorialEstado h8 = new HistorialEstado(DateTime.Parse("10/13/2020 11:55:00 pm"), ea4, DateTime.Parse("11/13/2020 11:30:00 pm"));
            HistorialEstado h1 = new HistorialEstado(DateTime.Parse("10/13/2020 11:40:00 pm"), ed1, null);
            HistorialEstado h2 = new HistorialEstado(DateTime.Parse("10/13/2020 11:30:00 pm"), ed2, null);
            HistorialEstado h3 = new HistorialEstado(DateTime.Parse("10/13/2020 11:55:00 pm"), ed6, null);
            HistorialEstado h7 = new HistorialEstado(DateTime.Parse("10/13/2020 11:00:00 pm"), ed7, null);


            List<HistorialEstado> histD1 = new List<HistorialEstado>(); //this
            List<HistorialEstado> histD2 = new List<HistorialEstado>(); //this
            List<HistorialEstado> histD3 = new List<HistorialEstado>();
            List<HistorialEstado> histD4 = new List<HistorialEstado>();
            List<HistorialEstado> histD5 = new List<HistorialEstado>();
            List<HistorialEstado> histD6 = new List<HistorialEstado>(); //this
            List<HistorialEstado> histD7 = new List<HistorialEstado>(); //this

            histD1.Add(h4);
            histD1.Add(h1);
            histD2.Add(h5);
            histD2.Add(h2);
            histD6.Add(h6);
            histD6.Add(h3);
            histD7.Add(h8);
            histD7.Add(h7);
             
            DetallePedido d1 = new DetallePedido(1,3,histD1,p1,ed1,15, menu1, null); //prep
            DetallePedido d2 = new DetallePedido(2,1,histD2,p1,ed2,30, menu2, null); //prep
            DetallePedido d3 = new DetallePedido(3,1,histD3,p1,ed3,25, null, pdc3);
            DetallePedido d4 = new DetallePedido(4,9,histD4,p1,ed4,11, null, pdc1);
            DetallePedido d5 = new DetallePedido(5,4,histD5,p1,ed5,16, null, pdc2);
            DetallePedido d6 = new DetallePedido(6,5,histD6,p2,ed6,14, menu1, null); //prep
            DetallePedido d7 = new DetallePedido(7,4,histD7,p3,ed7,20, null, pdc4); //prep

            List<DetallePedido> detalles1 = new List<DetallePedido>();
            detalles1.Add(d1);
            detalles1.Add(d2);
            detalles1.Add(d3);
            detalles1.Add(d4);
            detalles1.Add(d5);
            detalles1.Add(d6);
            detalles1.Add(d7);



            return detalles1;
        }

        public void finalizarPedido(PantallaFinalizarPreparacionPedido p)
        {

            List<DetallePedido> detalles = cargarObjetos();
            detalles = buscarDetallesPedidoEnPreparacion(detalles);
            List<DetallePedido> detallesOrdenados = ordenarSegunTiempoDeEspera(detalles);
            List<List<string>> infoDetalles = buscarInfoDetallePedido(detallesOrdenados);
            p.cargar(infoDetalles);

        }

        public void finalizarPreparacion(List<int> listaId)
        {
            List<DetallePedido> listaEnPreparacion = BuscarDetallesPorId(listaId);
            foreach (var detalle in listaEnPreparacion)
            {
                detalle.finalizarPreparacion();
            }

            visualizarNotificacion(listaEnPreparacion);


            notificar(listaEnPreparacion);
        }
        private List<List<string>> buscarInfoDetallePedido(List<DetallePedido> detalles)
        {
            List<List<string>> infoDetalles = new List<List<string>>();
            
            foreach (var i in detalles)
            {
                List<string> listaInterior = new List<string>();
                string id = i.idDetalle.ToString();
                string nombre;
                string cantidad;
                string mesa;
                string mozo;
                if (i.menu == null && i.producto != null)
                {
                    nombre = i.mostrarNombreProducto();
                }
                else
                {
                    nombre = i.mostrarNombreMenu();
                }
                listaInterior.Add(id);
                listaInterior.Add(nombre);
                cantidad = i.cantidad.ToString();
                listaInterior.Add(cantidad);
                mesa = buscarMesaDelDetalleEnPreparacion(i);
                listaInterior.Add(mesa);
                mozo = buscarMozo(i);
                listaInterior.Add(mozo);
                infoDetalles.Add(listaInterior);

                
            }
            return infoDetalles;
        }

        private string buscarMozo(DetallePedido det)
        {
            return det.MostrarMozo();
        }

        private string buscarMesaDelDetalleEnPreparacion(DetallePedido det)
        {
            return det.mostrarMesa();
        }
        public List<DetallePedido> buscarDetallesPedidoEnPreparacion(List<DetallePedido> ListaDetalles)
        {   //Estet metodo obtiene el estado actual del dettalle sin pasar por el historial
            List<DetallePedido> detallesEnPrep = new List<DetallePedido>();
            foreach (var detalle in ListaDetalles)
            {
                if (detalle.estado is EnPreparacion)
                {
                    detallesEnPrep.Add(detalle);
                }

            }
            return detallesEnPrep;
        }

        public List<DetallePedido> buscarDetallesPedidoEnPreparacionConHistorial(List<DetallePedido> ListaDetalles)
        {   //Este metodo obtiene el estado actual del dettalle pasando por el historial
            List<DetallePedido> detallesEnPrep = new List<DetallePedido>();
            foreach (var detalle in ListaDetalles)
            {
                foreach (var hist in detalle.historial)
                {
                    if (hist.estado is EnPreparacion && hist.obtenerUltimoEstado())
                    {
                        detallesEnPrep.Add(detalle);
                    }
                }

            }
            return detallesEnPrep;
        }

        private List<DetallePedido> ordenarSegunTiempoDeEspera(List<DetallePedido> detalles)
        {
            int N = detalles.Count();
            for (int i = 0; i < N - 1; i++)
            {
                for (int j = 0; j < N - 1; j++)
                {
                    TimeSpan tiempoDeEsperaCotaInf = detalles[j].calcularEspera();
                    TimeSpan tiempoDeEsperaCotaSup = detalles[j+1].calcularEspera();
                    if (tiempoDeEsperaCotaInf < tiempoDeEsperaCotaSup)
                    {
                        DetallePedido temp = detalles[j];
                        detalles[j] = detalles[j + 1];
                        detalles[j + 1] = temp;
                    }
                }
            }
            return detalles;
        }

        private List<DetallePedido> ordenarSegunDemoraDePlato(List<DetallePedido> detalles)
        {
            int N = detalles.Count();
            for (int i = 0; i < N-1; i++)
            {
                for (int j = 0; j < N - 1; j++)
                {
                    if (detalles[j].tiempoEsperaEnMin < detalles[j + 1].tiempoEsperaEnMin)
                    {
                        DetallePedido temp = detalles[j];
                        detalles[j] = detalles[j + 1];
                        detalles[j + 1] = temp;
                    }
                }
            }
            return detalles;
        }

        private List<DetallePedido> ordenarSegunMozo(List<DetallePedido> detalles)
        {
            int N = detalles.Count();
            for (int i = 0; i < N - 1; i++)
            {
                for (int j = 0; j < N - 1; j++)
                {
                    int comparacion = detalles[j].MostrarMozo().CompareTo(detalles[j + 1].MostrarMozo());
                    if (comparacion != 1)
                    {
                        DetallePedido temp = detalles[j];
                        detalles[j] = detalles[j + 1];
                        detalles[j + 1] = temp;
                    }
                }
            }
            return detalles;
        }

        private void visualizarNotificacion(List<DetallePedido> listaNotificar)
        {
            VisualListoParaSevir visual = new VisualListoParaSevir();
            visual.Show();
            List<List<string>> datosVisuaizacionNotificado = buscarDatosVisual(listaNotificar);
            visual.visualizarNotificacion(datosVisuaizacionNotificado);

        }

        private List<List<string>> buscarDatosVisual(List<DetallePedido> listaNotificar)
        {
            List<List<string>> datosNotificacion = new List<List<string>>();
            foreach (var i in listaNotificar)
            {
                List<string> listaInterna = new List<string>();
                string mesa = i.mostrarMesa();
                string cantidad = i.cantidad.ToString();
                string prod;
                if (i.menu == null && i.producto != null)
                {
                    prod = i.mostrarNombreProducto();
                }
                else
                {
                    prod = i.mostrarNombreMenu();
                }

                listaInterna.Add(mesa);
                listaInterna.Add(prod);
                listaInterna.Add(cantidad);
                datosNotificacion.Add(listaInterna);
            }
            return datosNotificacion;
        }

        public void notificar(List<DetallePedido> listaPendiente)
        {
            foreach (var detalle in listaPendiente)
            {
                detalle.notificar();
            }
        }

        public List<DetallePedido> BuscarDetallesPorId(List<int> listaID)
        {
            List<DetallePedido> detalles = cargarObjetos();
            List<DetallePedido> detallesSelect = new List<DetallePedido>();
            foreach (var det in detalles)
            {
                var exists = listaID.Contains(det.idDetalle);
                if (exists )
                {
                    detallesSelect.Add(det);
                }
            }
            return detallesSelect;
        }
    }
}
