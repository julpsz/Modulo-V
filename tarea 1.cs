using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_1
{
    class Program
    {
        public static int Signo (int x)
        {
            if (x < 0)
                return -1;
            else
                return 1;
        }
        static void Main(string[] args)
        {
            int num, signo;
            Console.WriteLine("Ingrese un numero real");
            num = Convert.ToInt32(Console.ReadLine());
            signo = Signo(num);
            Console.WriteLine("Devuelve: {0}", signo);
            Console.ReadKey();
        }
    }
}
