using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
    class PrivateClass
    {
        private static string model = "Mustang";
        static void Main(string[] args)
        {
            PrivateClass obj = new PrivateClass();
            Console.WriteLine(model);

        }

    }
    class NewClass
    {
        private string model = "Royce Royal";
    }
}
