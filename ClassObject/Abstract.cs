using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
    abstract class animal1
    {
        public abstract void animalSound1();
        
        public void sleep()
        {
             Console.WriteLine("Zzz");
        }

        
    }
    class Pig1 : animal1
    {
        public override void animalSound1()
        {
            Console.WriteLine("The Pigs Says: Wee Wee");
        }
    }
    class Abstract
    {
        static void main(string[] args)
        {
            Pig1 myPig1 = new Pig1();
            myPig1.animalSound1();
            myPig1.sleep();
        }
    }
}
    
