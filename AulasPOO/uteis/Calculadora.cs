﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasPOO.uteis
{
    public class Calculadora
    {
        public int Soma(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Mult(int num1, int num2)
        {
            return num1 * num2;
        }
        public static double IMC(double peso, double alt)
        {
            return peso / Math.Pow(alt, 2);
        }
    }
}
