﻿using System;

namespace Calculadora
{
    public class Multiplication : AOperation
    {
        private double _Firstvalue;
        private double _Secondvalue;

        public Multiplication(double Firstvalue, double Secondvalue)
        {
            _Firstvalue = Firstvalue;
            _Secondvalue = Secondvalue;
        }

        public double Equals()
        {
            return _Firstvalue * _Secondvalue;
        }
    }
}