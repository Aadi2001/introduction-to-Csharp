using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AdvanceTopic
{
    class Threading
    {
        public static void CallToChildThread()
        {
            Console.WriteLine("Child Thread Started");
            int sleepfor = 5000;
            Console.WriteLine("Child Thread Paused for {`.0} Seconds", sleepfor / 1000);
            Thread.Sleep(sleepfor);
            Console.WriteLine("Child Thread Resumes");


        }
        static void main(String[] args)
        {
            ThreadStart childref = new ThreadStart(CallToChildThread);
            Console.WriteLine("In Main: Creating  the child thread");
            Thread childThread = new Thread(childref);
            childThread.Start();
            childThread.Join();
            Console.WriteLine("Thread Stopped");
        }
    }
}
