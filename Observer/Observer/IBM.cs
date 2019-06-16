using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    /// <summary>

    /// The 'ConcreteSubject' class

    /// </summary>

    class IBM : AbstractStock

    {
        // Constructor

        public IBM(string symbol, double price)
          : base(symbol, price)
        {
        }
    }
}
