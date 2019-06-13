using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class GCALGetPDFProcess : GetPDFProcess
    {
        public override void Get()
        {
            Console.WriteLine("Getting PDF for GCAL...");
        }

    }
}
