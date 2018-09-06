using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Platillos> platillo1 = new List<Platillos>();

            Platillos platillos = new Platillos();

            platillos.Nombre = "Hamburguesa";
            platillos.Descripcion = "Solo se sirve el jueves";
            platillos.Precio = "50";

            platillo1.IngredientesAdd(new Ingredientes("Carne"));
            ingredientes.Add(new Ingredientes("Pan"));
            ingredientes.Add(new Ingredientes("Queso"));
            ingredientes.Add(new Ingredientes("Gargajo"));

            platillo1.Add(Ingredientes);
        }
    }
}
