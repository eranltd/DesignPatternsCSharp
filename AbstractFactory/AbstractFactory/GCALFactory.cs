using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    /// <summary>

    /// The 'GCALFactory' class

    /// </summary>
    class GCALFactory : LabActionsFactory
    {
        public override GetStonePropsProcess CreateGetStonePropsProcess()
        {
            return new GCALGetStonePropsProcess();
        }
        public override GetPDFProcess CreateGetPDFProcess()
        {
            return new GCALGetPDFProcess();
        }
    }
}
