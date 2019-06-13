using System;

namespace ChainOfResp.Structural
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup Chain of Responsibility

            AbstractHandler h1 = new HandlerA();
            AbstractHandler h2 = new HandlerB();
            AbstractHandler h3 = new HandlerC();
            h1.SetSuccessor(h2);
            h2.SetSuccessor(h3);

            // Generate and process request

            int[] requests = { 2, 5, 14, 22, 18, 3, 27, 20 };

            foreach (int request in requests)
            {
                h1.HandleRequest(request);
            }

            // Wait for user

            Console.ReadKey();
        }
    }
    }

