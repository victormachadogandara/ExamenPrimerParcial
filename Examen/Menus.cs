using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Menus
    {
        public string Nombre { get; set; }
        public string HoraInicio { get; set; }
        public string HoraFin { get; set; }
        public string Identificador { get; set; }
        public Platillos platillos { get; set; }

        List<Platillos> platillo { get; set; }


    }
}
