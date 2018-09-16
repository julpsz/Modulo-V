using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_5
{
    class Program
    {
        public static float Suma(float n1, float n2)
        {
            return n1 + n2;        
        }
        public static float Resta(float n1, float n2)
        {
            return n1 - n2;
        }
        public static float Multiplicacion(float n1, float n2)
        {
            return n1 * n2;
        }
        public static float Division(float n1, float n2)
        {
            return n1 / n2;
        }


        static void Main(string[] args)
        {
            float num1, num2, resultado=0;
            int opcion;
            Console.WriteLine("Ingrese opcion:\n" +
                "1. Suma\n" +
                "2. Resta\n" +
                "3. Multiplicacion\n" +
                "4. Division\n\n");
            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    {
                        Console.WriteLine("Ingrese los 2 numeros a operar: ");
                        num1 = Convert.ToSingle(Console.ReadLine());
                        num2 = Convert.ToSingle(Console.ReadLine());
                        resultado = Suma(num1, num2);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Ingrese los 2 numeros a operar: ");
                        num1 = Convert.ToSingle(Console.ReadLine());
                        num2 = Convert.ToSingle(Console.ReadLine());
                        resultado = Resta(num1, num2);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Ingrese los 2 numeros a operar: ");
                        num1 = Convert.ToSingle(Console.ReadLine());
                        num2 = Convert.ToSingle(Console.ReadLine());
                        resultado = Multiplicacion(num1, num2);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Ingrese los 2 numeros a operar: ");
                        num1 = Convert.ToSingle(Console.ReadLine());
                        num2 = Convert.ToSingle(Console.ReadLine());
                        resultado = Division(num1, num2);
                        break;
                    }
            }
            Console.WriteLine("El resultado es: {0}", resultado);
            Console.ReadKey();
        }
    }
}
