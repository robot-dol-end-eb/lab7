﻿using System;
using System.Collections.Generic;

namespace laba1
{
  
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0, c = 0;
            Console.WriteLine("Введите 3 параметра a, b и с");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            MyLog.log("Введено уравнение: " + a + "X^2+" + b + "X+" + c + "=0");
            try
            {
                QuaEquation calc = new QuaEquation();
                List<double> res = calc.solve(a, b, c);
                String s = "Корни уравнения: ";
                foreach (double i in res)
                {
                    s += i + " ";
                }
                MyLog.log(s);
            }
            catch (VasikhinException e)
            {
                MyLog.log("Ошибка: " + e.Message);
            }
            MyLog.write();
            Console.ReadKey();
        }
    }
}

