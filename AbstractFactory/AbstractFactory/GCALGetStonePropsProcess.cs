using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class GCALGetStonePropsProcess : GetStonePropsProcess
    {
        public override void Get()
        {
            Console.WriteLine("Getting StoneProps for GCAL...");
        }
    }
}
