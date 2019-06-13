using Facade.SubSystems;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    /// <summary>

    /// The 'Facade' class

    /// </summary>

    class Facade

    {
        private SubSystemOne _one;
        private SubSystemTwo _two;

        public Facade()
        {
            _one = new SubSystemOne();
            _two = new SubSystemTwo();
        }

        public void MethodA()
        {
            Console.WriteLine("\nMethodA() ---- ");
            _one.MethodOne();
        }

        public void MethodB()
        {
            Console.WriteLine("\nMethodB() ---- ");
            _two.MethodTwo();
        }
    }
}

