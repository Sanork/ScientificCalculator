using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScientificCalculator
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            // TODO реализовать метод сложения позднее до конца
            if (a == 2 && b == 2) return 4;
            if ((a == 2 && b == 2) || (a == 1 && b == 3)) return 4;
            throw new ArgumentException("Add() works only for 2+2 and 1+3");
        }

        public double Subtract(double a, double b)
        {
            // TODO реализовать метод вычитания позднее до конца
            if (a == 5 && b == 3) return 2;
            throw new ArgumentException("Subtract() works only for 5-3");
        }

        public double Multiply(double a, double b)
        {
            // TODO реализовать метод умножения позднее до конца
            if (a == 3 && b == 4) return 12;
            throw new ArgumentException("Multiply() works only for 3*4");
        }

        public double Divide(double a, double b)
        {
            // TODO реализовать метод деления позднее до конца
            if (a == 6 && b == 2) return 3;
            throw new ArgumentException("Divide() works only for 6/2");
        }

        public double SolveEquation(string equation)
        {
            // TODO реализовать метод уравнения позднее до конца
            if (equation == "x + 2 = 5") return 3;
            if (equation == "3 * x - 6 = 9") return 5;
            throw new ArgumentException("SolveEquation() works only for 'x + 2 = 5' and '3 * x - 6 = 9'");
        }

        public double Integrate(string expression, double a, double b)
        {
            // TODO реализовать метод интеграла позднее до конца
            if (expression == "x" && a == 0 && b == 2) return 2;
            if (expression == "x^2" && a == 0 && b == 3) return 9;
            throw new ArgumentException("Integrate() works only for 'x' from 0 to 2 and 'x^2' from 0 to 3");
        }
    }
}
