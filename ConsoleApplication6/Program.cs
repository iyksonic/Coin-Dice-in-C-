using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            float a;
            Random generator = new Random();
            a = (float)generator.NextDouble();
           

            if (a > 0.5f)
            {
                Console.WriteLine("Head");
            }
            else
            {
                Console.WriteLine("Tail");
            }

            Console.ReadLine();

        }
    }
}
