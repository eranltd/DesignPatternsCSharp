using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    /// <summary>   
    /// Concrete Car   
    /// </summary>   
    public class LuxuryCar : ICar
    {
        public string GetDescription()
        {
            return "Luxury Car";
        }

        public double GetCost()
        {
            return 1000000.0;
        }
    }
}
