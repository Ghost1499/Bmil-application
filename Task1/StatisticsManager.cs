﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class StatisticsManager
    {
        public StatisticsManager()
        {
           
        }


        public double GetPasswordMathExpectasion(long[] passwordDurations)
        {
            return MathExpectation(passwordDurations);
        }

        public double GetPasswordDispersion(long[] passwordDurations)
        {
            return Dispersion(passwordDurations);
        }
        public long[] GetPasswordDurations(List<PasswordAction> passwordActions)//исправить long и int
        {
            long[] result = new long[passwordActions.Count()];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = passwordActions[i].TimeDuration;
            }
            return result;
        }

        public long[] GetTypingDinamic(PasswordAction passwordAction,out string[] typedSymbols)
        {
            int n = passwordAction.SymbolActions.Count();
            long[] result = new long[n];
            for (int i = 0; i < n; i++)
            {
                if (i < 1)
                {
                    result[i] = passwordAction.SymbolActions[i].KeyDownTime;
                }
                else
                {
                    result[i] = passwordAction.SymbolActions[i].KeyDownTime- passwordAction.SymbolActions[i-1].KeyDownTime;
                }
            }
            typedSymbols = passwordAction.GetTypedSymbols();
            return result;
        }

        public static double Dispersion<T>(T[] values)
        {
            return Dispersion(values.Cast<double>().ToArray());
        }
        public static double Dispersion(double[] values)
        {
            double m = MathExpectation(values);
            double[] result = new double[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                double val= (values[i] - m)*(values[i]-m);
                result[i] = val;
            }
            return MathExpectation(result);
        }

        public static double MathExpectation(double[] values)
        {
            double sum = 0;
            foreach (var value in values)
            {
                sum +=  value;
            }
            return sum / (double)values.Length;
        }
        public static double MathExpectation<T>(T[] values)
        {
            return MathExpectation(values.Cast<double>().ToArray());
        }
    }
}
