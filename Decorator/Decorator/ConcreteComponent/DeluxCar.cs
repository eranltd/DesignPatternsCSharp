using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    /// <summary>   
    /// Concrete Car   
    /// </summary>   
    public class DeluxCar : ICar
    {
        public string GetDescription()
        {
            return "Delux Car";
        }

        public double GetCost()
        {
            return 750000.0;
        }
    }
}
