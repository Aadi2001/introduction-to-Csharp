using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class multParam
    {
        public static void methodtwo(string fname, string weapon)
        {
            Console.WriteLine(fname + " is having " + weapon);

        }
        static void main(string[] args)
        {
            methodtwo("aditya", "AK-47");
            methodtwo("Lucifer", "AWM");
            methodtwo("Sensei", "M416");
        }
    }
}
