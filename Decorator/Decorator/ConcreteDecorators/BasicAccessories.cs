using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    /// <summary>   
    /// Concrete Decorator   
    /// </summary>   
    public class BasicAccessories : CarAccessoriesDecorator
    {
        public BasicAccessories(ICar aCar)
        : base(aCar)
        {

        }

        public override string GetDescription()
        {
            return base.GetDescription() + ",Basic Accessories Package";

        }

        public override double GetCost()
        {
            return base.GetCost() + 2000.0;
        }
    }
}
