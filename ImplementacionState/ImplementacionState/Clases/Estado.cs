using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionState
{
    public class Estado
    {
        public string ambito { get; set; }
        public string nombre { get; set; }


        public Estado(string a, string n)
        {
            this.ambito = a;
            this.nombre = n;

        }
    }

}
