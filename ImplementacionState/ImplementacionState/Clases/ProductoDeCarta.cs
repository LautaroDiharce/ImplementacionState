using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionState.Clases
{
    public class ProductoDeCarta
    {      
        public string nombre { get; set; }
        public double precio{ get; set; }
        
        public Producto producto { get; set; }

        public ProductoDeCarta(Producto producto)
        {
            this.nombre = producto.nombre;
            this.precio = producto.precio;
            this.producto = producto;
        }

        public string mostrarProducto()
        {
            return producto.nombre;
        }
    }
}
