using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
     class Message
    {
        private string messageText;
        public Message(string s)
        {
            messageText = s;
        }
        public override string ToString()
        {
            return messageText;
        }
        
        class Buffer
        {
            private Queue messageBuffer;

            public void SendMessage(Message m)
            {
                messageBuffer.Enqueue(m);
                Console.WriteLine("Sent: " + m.ToString());
            }
            public void RecieveMessage()
            {
                Message m = (Message)messageBuffer.Dequeue();
                Console.WriteLine("Recieved: " + m.ToString());

            }
            public Buffer()
            {
                messageBuffer = new Queue();
            }

        }
        class OwnQueue
        {
            static void main(string[] args)
            {
                Queue q = new Queue();
                q.Enqueue('A');
                q.Enqueue('B');
                q.Enqueue('C');
                
                Console.Write("New Queue: ");
                foreach (char c in q)
                    Console.WriteLine(c + " ");
                q.Enqueue('D');
                q.Enqueue('E');
                Console.WriteLine();
                Console.Write("Updating Queue: ");
                foreach (char c in q)
                    Console.WriteLine(c + " ");

                char ch = (char)q.Dequeue();
                Console.Write("Removed Value: " + ch);

                ch = (char)q.Dequeue();
                Console.WriteLine("Value Removed: " + ch);


                Console.WriteLine("Updated Queue: ");
                foreach (char c in q)
                    Console.Write(c + "C");
                

                //Buffer buf = new Buffer();
                //buf.SendMessage(new Message("One"));
                //buf.SendMessage(new Message("Two"));
                //buf.RecieveMessage
                //buf.SendMessage(new Message("Three"));
                //buf.SendMessage(new Message("Four"));
            }
        }
    }
}
