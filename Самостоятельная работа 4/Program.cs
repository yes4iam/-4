using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Самостоятельная_работа_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число больше нуля");
            int n = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            int p = 2 * n - 1;
            for (int i=1; i<=n;i++)
            {
                s = i*i;
                Console.WriteLine(s);
            }
            Console.ReadKey();

        }
    }
}
