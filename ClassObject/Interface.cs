using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
    interface Ianimal
    {
        void AnimalSound();

    }
    class pig3 : Ianimal
    {
        public void AnimalSound()
        {
            Console.WriteLine("Pigs says: Wee Wee");
        }
    }


    class Interface
    {
        static void main(string[] args)
        {
            pig3 mypig = new pig3();
            mypig.AnimalSound();
        }
    }
}
