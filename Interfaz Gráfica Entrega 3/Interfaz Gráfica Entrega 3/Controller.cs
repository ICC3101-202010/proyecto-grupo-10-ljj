using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_Gráfica_Entrega_3
{
    public abstract class Controller
    {
        abstract public string Search();

        public void OperationSearch()
        {
            Console.WriteLine($"Se ha encontrado lo siguiente con la busqueda");
            Console.WriteLine($"{Search()}");
        }
    }
}
