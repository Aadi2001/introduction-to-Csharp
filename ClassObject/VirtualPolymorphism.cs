using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
    class Animal2
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The Animal Makes This Sound");
        }

    }
    class pig2 : Animal2
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig make Weeeee..!");

        }
    }
    class dog2 : Animal2
    {
        public override void animalSound()
        {
            Console.WriteLine("The Dog says: Bow Bow..!");

        }
    }

    class VirtualPolymorphism
    {
        static void main(string[] args)
        {
            Animal2 myAnimal = new Animal2();
            Animal2 myPig = new pig2();
            Animal2 myDog = new dog2();

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();
        }



    }
}
