using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public delegate string MyDel(string str);
namespace AdvanceTopic
{
    class MyClass
    {
        event MyDel MyEvent;
        public MyClass()
        {
            this.MyEvent += new MyDel(this.WelcomeMsg);

        }
        public string WelcomeMsg(string username)
        {
            return "Welcome Msg" + username;
        }
        static void main(string[] args)
        {
            MyClass obj1 = new MyClass();
            string result = obj1.MyEvent("Arjuna");
            Console.WriteLine(result);
        }
    }
}
