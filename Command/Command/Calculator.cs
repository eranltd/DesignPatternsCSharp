using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    /// <summary>

    /// The 'Receiver' class

    /// </summary>

    class Calculator
    {
        private int _balance = 0;

        public void Operation(char @operator, int operand)
        {
            switch (@operator)
            {
                case '+':
                    _balance += operand;
                    break;

                case '-':
                    _balance -= operand;
                    break;

                case '*':
                    _balance *= operand;
                    break;

                case '/':
                    _balance /= operand;
                    break;
            }

            Console.WriteLine("Current value = {0,3} (following {1} {2})",_balance, @operator, operand);
        }
    }
}
