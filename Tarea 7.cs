using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_7
{
    class Program
    {
        public static void Triangulo(string let, int cant)
        {
            int i=cant, j;
            while(i != -1)
            {
                for (j = 0; j <= cant; j++)
                {
                    Console.Write("{0}", let);
                }
                Console.Write("\n");
                cant--;
                i--;
            }    
        }

        static void Main(string[] args)
        {
            string letra;
            int numero;
            Console.WriteLine("Ingrese una letra: ");
            letra = Console.ReadLine();
            Console.WriteLine("Ingrese un numero de veces: ");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Triangulo(letra, numero);
            Console.ReadLine();
        }
    }
}
