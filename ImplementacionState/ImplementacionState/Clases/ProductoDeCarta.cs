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

        public ProductoDeCarta(string nombre, double precio, Producto producto)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.producto = producto;
        }
    }
}
