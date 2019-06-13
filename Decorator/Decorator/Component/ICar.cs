using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    /// <summary>   
    /// Car Base component   
    /// </summary>   
    public interface ICar
    {
        string GetDescription();
        double GetCost();
    }
}
