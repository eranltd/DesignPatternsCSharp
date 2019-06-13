using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    /// <summary>

    /// The 'LabActions' abstract class

    /// </summary>
    abstract class LabActionsFactory
    {
        public abstract GetStonePropsProcess CreateGetStonePropsProcess();
        public abstract GetPDFProcess CreateGetPDFProcess();
    }
}
