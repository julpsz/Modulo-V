using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_6
{
    class Program
    {
        public static int suma(int[] vec, int cantidad)
        {
            int j, resultado=0;
            for (j = 0; j < cantidad; j++)
                resultado = resultado + vec[j];
            return resultado;
        }
        static void Main(string[] args)
        {
            int i, cant, res;
            

            Console.WriteLine("Ingrese la cantidad de digitos que tiene el numero: ");
            cant = Convert.ToInt32(Console.ReadLine());
            int[] vector = new int[cant];

            for (i = cant -1; i >=0 ; i--)
            {
                Console.WriteLine("Ingrese digito del numero: ");
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }

            res = suma(vector, cant);
            Console.WriteLine("La suma de las cifras es {0}", res);
            Console.ReadKey();

            

        }
    }
}
