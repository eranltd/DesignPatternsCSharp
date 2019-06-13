using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResp
{
    /// <summary>

    /// The 'Handler' abstract class

    /// </summary>

    abstract class AbstractHandler

    {
        protected AbstractHandler successor;

        public void SetSuccessor(AbstractHandler successor)
        {
            this.successor = successor;
        }

        public abstract void HandleRequest(int request);
    }
}
