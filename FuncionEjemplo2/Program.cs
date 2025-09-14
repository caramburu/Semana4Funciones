using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionEjemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola");
            IngresarDatos();

        }

        static void IngresarDatos()
        {
            String Nombre;
            Console.Write("Registre su nombre completo:");
            Nombre = Console.ReadLine();

            Console.WriteLine("El nombre registrado es: "+Nombre);
        }
    }
}
