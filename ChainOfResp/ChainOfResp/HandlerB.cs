using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResp
{
    /// <summary>

    /// The 'ConcreteHandler2' class

    /// </summary>

    class HandlerB : AbstractHandler

    {
        public override void HandleRequest(int request)
        {
            if (request >= 10 && request < 20)
            {
                Console.WriteLine("{0} handled request {1}",
                  this.GetType().Name, request);
            }
            else if (successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }
}
