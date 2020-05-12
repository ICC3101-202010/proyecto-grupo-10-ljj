using System;
namespace Entrega2ProyectoLJJ
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
