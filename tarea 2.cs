using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_2
{
    class Program
    {
        public static int Menor (int n1, int n2)
        {
            if (n1 > n2)
                return n2;
            else
                return n1;
            
        }

        public static void Main(string[] args)
        {
            int num1, num2, valor;
            Console.WriteLine("Ingrese un numero entero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero entero");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Los numeros son iguales");
            }
            else
            {
                valor = Menor(num1, num2);
                Console.WriteLine("El numero menor de los dos ingresados es {0}", valor);
                
            }
            Console.ReadKey();
        }
    }
}
