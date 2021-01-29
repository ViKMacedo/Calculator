using System;

namespace Calculadora
{
    public class Operations
    {
        private AOperation _operation;

        public Operations(AOperation operation)
        {
            _operation = operation;
        }

        public double Equals()
        {
            return _operation.Equals();
        }
    }
}