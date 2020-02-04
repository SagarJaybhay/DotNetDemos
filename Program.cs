using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            demo d = new demo();
            Console.WriteLine("Number of Generation Supporting "+ GC.MaxGeneration.ToString());
            Console.WriteLine("Generation for this object  " + GC.GetGeneration(d));
            Console.WriteLine("Generation Total Memory  " + GC.GetTotalMemory(true));
            Console.Read();
        }
    }


    class demo
    {
        private int i = 0;
        private static string str = string.Empty;

        public void calculate()
        {
            for (int i = 0; i < 100; i++)
            {
                str += i * 1000;
            }
        }
    }


}
