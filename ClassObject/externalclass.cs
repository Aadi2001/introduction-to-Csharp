using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
    class externalclass
    {
        static void main(string[] args)
        {
            OwnClass obj = new OwnClass();

            Console.WriteLine(obj.Color);
            Console.WriteLine(obj.findEvenOdd(9));
            Console.WriteLine(obj.findEvenOdd(2));
        }
    }
}
