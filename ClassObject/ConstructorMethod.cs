using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
    class ConstructorMethod
    {
        static void Main(string[] args)
        {
            Car Ford = new Car("Mustang", "Red", 1969);
            Car RB = new Car("Astra", "White", 2005);
            Console.WriteLine(Ford.Model);
            Console.WriteLine(RB.Model);

        }
    }
    class car
    {
        public string model;
        public string color;
        public int year;

    public car(string)

