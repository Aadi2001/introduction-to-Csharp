using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
    sealed class vehicle2
    {
        public string brand = "Ford";
        public void honk()
        {
            Console.WriteLine("Beeeeeeeeeeeeeep, Beeep, Beep");

        }

    }
    class ford //Vehicle2
    {
        public string modelName = "Mustang";
    }

    class seeledClass
    {
        static void Main(string[] args)
        {
            ford myCar = new ford();
            Console.WriteLine(myCar.modelName);
            //myCar.honk();
            vehicle2 obj = new vehicle2();
            obj.honk();
        }
    }
}
