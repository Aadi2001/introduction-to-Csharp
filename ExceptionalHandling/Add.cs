using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionalHandling
{
    class Add
    {
        static void Main(string[] args)
        {
            long x = long.Parse(Console.ReadLine());
            long y = long.Parse(Console.ReadLine());

            long sum = (x + y);
            Console.WriteLine(sum);
        }
    }
}
