﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sciencetific_Calc
{
    class Operators
    {
        public static int Add(int n1, int n2)
        {
            return n1 + n2;
        }

        public static Double Add(Double n1, Double n2)
        {
            return n1 + n2;
        }

        public static int Sub(int n1, int n2)
        {
            return n1 - n2;
        }

        public static Double Sub(Double n1, Double n2)
        {
            return n1 - n2;
        }

        public static int Div(int n1, int n2)
        {
            return n1 / n2;
        }

        public static Double Div(Double n1, Double n2)
        {
            return n1 / n2;
        }

        public static int Mult(int n1, int n2)
        {
            return n1 * n2;
        }

        public static Double Mult(Double n1, Double n2)
        {
            return n1 * n2;
        }

        public static Double sqrt(int n1)
        {
            return Math.Sqrt(n1);
        }

        public static Double sqrt(Double n1)
        {
            return Math.Sqrt(n1);
        }

        public static Double sq(int n1)
        {
            return n1 * n1;
        }

        public static Double sq(Double n1)
        {
            return n1 * n1;
        }

        public static Double percent(int n1)
        {
            return n1 / 100;
        }

        public static Double percent(Double n1)
        {
            return n1 / 100;
        }

        public static Double x3(int n1)
        {
            return n1 * n1 * n1;
        }

        public static Double x3(Double n1)
        {
            return n1 * n1 * n1;
        }
    }
}
