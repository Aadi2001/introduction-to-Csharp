using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate int ValueChanger(int n);
namespace AdvanceTopic
{
    class Delegates
    {
        static int value = 9;
        public static int AddVal(int n)
        {
            value += n;
            return value;
        }
        public static int SubVal(int n)
        {
            value -= n;
            return value;
        }
        public static int GetVal()
        {
            return value;
        }
        static void main(string[] args)
        {
            ValueChanger methodObj1 = new ValueChanger(AddVal);
            ValueChanger methodObj2 = new ValueChanger(SubVal);
            methodObj1(9);
            Console.WriteLine("Value: " + GetVal());
            methodObj2(5);
            Console.WriteLine("Value: " + GetVal());
        }
    }
}
