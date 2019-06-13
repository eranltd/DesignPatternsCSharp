using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class LABWorld
    {
        private GetStonePropsProcess _getStonePropsProcess;
        private GetPDFProcess _getPDFProcess;

        // Constructor

        public LABWorld(LabActionsFactory factory)
        {
            _getStonePropsProcess = factory.CreateGetStonePropsProcess();
            _getPDFProcess = factory.CreateGetPDFProcess();
        }

        public void RunAcions()
        {
            _getStonePropsProcess.Get();
            _getPDFProcess.Get();
        }


    }
}
