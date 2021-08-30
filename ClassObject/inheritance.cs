using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{

    class vehicle
    {
        public string brand = "Ford";
        public void honk()
        {
            Console.WriteLine("Beep", "BeeP.!");
        }
    }
    class ar : vehicle
    {
        public string ModelName = "Mustang";

    }

    class inheritance
    {
        static void main(string[] args)
        {
            ar myCar = new ar();
            myCar.honk();
            Console.WriteLine(myCar.brand + "" + myCar.ModelName);

     
        }
    }
}
