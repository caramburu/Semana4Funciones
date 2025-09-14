using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionEjemplo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Numero;
            int Opcion;

            Console.WriteLine("MENU TABLAS DE OPERACIÓN");
            Console.WriteLine("1. SUMA");
            Console.WriteLine("2. MULTIPLICACIÓN");
            Console.WriteLine("3. RESTA");
            Console.Write("Seleccione la opción a ejecutar:");
            Opcion = int.Parse(Console.ReadLine());           
            Console.Write("Registrar número a operar: ");
            Numero = int.Parse(Console.ReadLine());

            if (Opcion == 1)
            {
                Suma(Numero);
            }
            else if (Opcion == 2)
            {
                Multiplicar(Numero);
            }
            else if (Opcion == 3)
            {
                Resta(Numero);
            }
            else
            {
                Console.WriteLine("Opción inválida");
            }

                
        }
        static void Suma (int Numero)
        {
            for (int i =0; i <= 12; i++)
            {
                Console.WriteLine(+Numero+ " + "+i+" = "+(Numero+i));
            }
        }

        static void Multiplicar (int Numero)
        {
            for (int i = 0; i <= 12; i++)
            {
                Console.WriteLine(+Numero + " X " + i + " = " + (Numero * i));
            }
        }
        static void Resta(int Numero)
        {
            for (int i = 0; i <= 12; i++)
            {
                Console.WriteLine(+Numero + " - " + i + " = " + (Numero - i));
            }
        }
    }
}
