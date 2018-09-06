using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Platillos
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Precio { get; set; }
        public string Identificador { get; set; }

        List<ingredientes> Ingredientes { get; set; }

        public Platillos()
        {
            Ingredientes = new List<ingredientes>();

            Nombre = "Comida del dia";
            Descripcion = "Solo se sirve los jueves";
            Precio = 50;
            Identificador ="PTL4251";
        }
    }
}
