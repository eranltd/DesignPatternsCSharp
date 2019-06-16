using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    /// <summary>

    /// The 'Observer' interface

    /// </summary>

    interface IInvestor

    {
        void Update(AbstractStock stock);
    }
}
