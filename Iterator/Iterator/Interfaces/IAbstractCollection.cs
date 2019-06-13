using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    /// <summary>

    /// The 'Aggregate' interface

    /// </summary>

    interface IAbstractCollection

    {
        Iterator CreateIterator();
    }
}
