using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionState.Clases
{
    public class Producto
    {
        public string nombre { get; set; }
        public double precio { get; set; }

        public Producto(string nombre, double precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }
    }
}
