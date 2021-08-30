using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
    class Animal
    {
        public void animalsound()
        {
            Console.WriteLine("The Animal Makes This Sound");
        }

    }
    class pig : Animal
    {
        public void animalsound()
        {
            Console.WriteLine("The pig make Weeeee..!");

        }
    }
    class dog : Animal
    {
        public void animalsound()
        {
            Console.WriteLine("The Dog says: Bow Bow..!");

        }
    }

    class Polymorphism
    {
        static void main(string[] args)
        {
            Animal myAnimal = new Animal();
            Animal myPig = new pig();
            Animal myDog = new dog();

            myAnimal.animalsound();
            myPig.animalsound();
            myDog.animalsound();
        }



    }
}
