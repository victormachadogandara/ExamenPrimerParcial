using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Ingredientes
    {
        public string Nombre { get; set; }
        public string Indetificador { get; set; }

        public Ingredientes(string tomate, string TM123)
        {
            Nombre = tomate;
            Indetificador = TM123;
        }
    }

   
}
