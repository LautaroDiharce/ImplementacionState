using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionState.Clases
{
    public class GestorFinalizarPreparacionPedido
    {



        public List<Estado> CargarEstados()
            {
            
                List<Estado> estados = new List<Estado>();

                Estado e1 = new Estado("Pedido", "Creado");
                Estado e2 = new Estado("Pedido", "Creado");
                Estado e3 = new Estado("Pedido", "En Preparacion");
                Estado e4 = new Estado("Pedido", "Cancelado");
                Estado e5 = new Estado("Detalle Pedido", "Creado");
                Estado e6 = new Estado("Detalle Pedido", "Cancelado");
                Estado e7 = new Estado("Detalle Pedido", "En Preparacion");
                Estado e8 = new Estado("Detalle Pedido", "Pendiente");
                Estado e9 = new Estado("Detalle Pedido", "En Preparacion");

                estados.Add(e1);
                estados.Add(e2);
                estados.Add(e3);
                estados.Add(e4);
                estados.Add(e5);
                estados.Add(e6);
                estados.Add(e7);
                estados.Add(e8);
                estados.Add(e9);
                return estados;
            }
        public List<Producto> CargarProductos()
        {
            List<Producto> prod = new List<Producto>();
            Producto p1 = new Producto("Papas", 20.5);
            Producto p2 = new Producto("Gaseosa", 40);
            Producto p3 = new Producto("Milanesa", 60);
            Producto p4 = new Producto("Cerveza", 85.5);
            Producto p5 = new Producto("Hamburguesa", 100);
            Producto p6 = new Producto("Pizza1", 120);
            Producto p7 = new Producto("Pizza2", 125);
            Producto p8 = new Producto("Pizza3", 200);
            Producto p9 = new Producto("Pizza4", 175);
            prod.Add(p1);
            prod.Add(p2);
            prod.Add(p3);
            prod.Add(p4);
            prod.Add(p5);
            prod.Add(p6);
            prod.Add(p7);
            prod.Add(p8);
            prod.Add(p9);
            return prod;
        }
        public List<ProductoDeCarta> CargarProductoCarta()
        {
            List<Producto> productos = CargarProductos();
            List<ProductoDeCarta> PdC = new List<ProductoDeCarta>();
            int i = 1;
            foreach (var Prod in productos)
            {
                ProductoDeCarta p = new ProductoDeCarta(Prod.nombre, Prod.precio, Prod);
                PdC.Add(p);

            }
            return PdC;
        }
        public List<Menu> CargarMenus()
        {
            List<Menu> menus = new List<Menu>();
            Menu m1 = new Menu("Menu clasico", 500);
            Menu m2 = new Menu("Menu Vegetariano", 500);
            Menu m3 = new Menu("Menu Ejecutivo", 500);

            menus.Add(m1);
            menus.Add(m2);
            menus.Add(m3);
            return menus;
        }

        public List<DetallePedido> CargarDetalles()
        {
            List<DetallePedido> detalles = new List<DetallePedido>();
            List<Menu> menus = CargarMenus();
            List<ProductoDeCarta> pdc = CargarProductoCarta();
            List<Estado> estados = CargarEstados();


            return detalles;
        }






        public List<Pedido> CargarPedidos()
        {
            List<Pedido> pedidos = new List<Pedido>();





            return pedidos;
        }
        public void finalizarPedido()
            {
                List<Estado> estados = CargarEstados();
                List<DetallePedido> detalles = new List<DetallePedido>();
                buscarDetallesPedidoEnPreparacion(estados);


                /*public List<DetallePedido> buscarDetallesPedidoEnPreparacion(List<Estado> estados)
                {
                    List<DetallePedido> lista = new List<DetallePedido>();
                    foreach (var estado in estados)
                    {
                        if (estado.ambito == "Detalle de Pedido")
                        {
                            //DetallePedido det = estado.
                        }

                    }
                    return lista;*/
            }
            public List<DetallePedido> buscarDetallesPedidoEnPreparacion(List<Estado> listaEst)
            {
                List<DetallePedido> detalles = new List<DetallePedido>();
                foreach (var estado in listaEst)
                {
                    if (estado.ambito == "Detalle Pedido" && estado.nombre == "En Preparacion")
                    {
                        detalles.Add(estado);
                    }
                }
                return detalles;
            }
    }
}
