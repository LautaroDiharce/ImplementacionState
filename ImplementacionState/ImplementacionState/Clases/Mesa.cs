using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionState.Clases
{
    public class Mesa
    {
        public int capacidad { get; set; }
        public string forma { get; set; }
        public int numero { get; set; }

        public string mozo { get; set; }

        public Mesa(int capacidad, string forma, int numero,string mozo)
        {
            this.capacidad = capacidad;
            this.forma = forma;
            this.numero = numero;
            this.mozo = mozo;
        }
    }
}
