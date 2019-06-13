using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    /// <summary>   
    /// Concrete Car   
    /// </summary>   
    public class EconomyCar : ICar
    {
        public string GetDescription()
        {
            return "Economy Car";
        }

        public double GetCost()
        {
            return 450000.0;
        }
    }
}
