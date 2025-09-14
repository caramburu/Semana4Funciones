using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionEjemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("primera llamada a la función: ");
            Saludo();
            Console.WriteLine("segunda llamada a la función: ");
            Saludo();
            Console.WriteLine("tercera llamada a la función: ");
            Saludo();
            Console.WriteLine("cuarta llamada a la función: ");
            Saludo();

        }

        static void Saludo()
        {
            Console.WriteLine("Bienvenidos a la semana 4");
        }
    }
}
