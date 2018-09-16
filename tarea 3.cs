using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Main
{
    class Program
    {
        public static void Primo(int n1)
        {
            int a = 0, i;
            for (i = 1; i < (n1 + 1); i++)
            {
                if (n1 % i == 0)
                {
                    a++;
                }
            }
            if (a != 2)
            {
                Console.WriteLine("No es Primo");
            }
            else
            {
                Console.WriteLine("Si es Primo");
            }
        }

        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Ingrese numero");
            n = Convert.ToInt32(Console.ReadLine());
            Primo(n);

            Console.ReadLine();
        }
    }
}