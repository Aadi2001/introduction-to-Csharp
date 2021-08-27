using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
    class ObjectMembers
    {
        string model;
        string color;
        int year;


        static void main(string[] args)
        {
            ObjectMembers honda = new ObjectMembers();
            honda.model = "CB";
            honda.color = "Black";
            honda.year = 2019;


            ObjectMembers RE = new ObjectMembers();
            RE.model = "Pulsar 220";
            RE.color = "Grey";
            RE.year = 2020;

            Console.WriteLine(honda.model + " " + honda.color + " " + honda.year);
            Console.WriteLine(RE.model + " " + RE.color + " " + RE.year);

        }
    }
}
