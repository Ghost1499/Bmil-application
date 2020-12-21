using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.MyMath
{
    public static class StatisticsMethods
    {
        public static double Sigma<T>(IEnumerable<T> values, in double dispersion = double.NaN)
        {
            return Sigma(values.Cast<double>(),dispersion);
        }

        public static double Sigma(IEnumerable<double> values, in double dispersion = double.NaN)
        {
            double d;
            if (dispersion == double.NaN)
            {
                d = Dispersion(values);
            }
            else
            {
                d = dispersion;
                
            }
            return System.Math.Pow(d, 0.5);
        }
        public static double Dispersion<T>(IEnumerable<T>  values, in double mathExpectation = double.NaN)
        {
            return Dispersion(values.Cast<double>().ToArray(),mathExpectation);
        }
        public static double Dispersion(IEnumerable<double> values, in double mathExpectation=double.NaN)
        {
            double m;
            if (mathExpectation == double.NaN)
            {
                m = MathExpectation(values);
            }
            else
            {
                m = mathExpectation;
            }
            double[] result = new double[values.Count()];
            int i = 0;
            double val;
            foreach (var item in values)
            {
                val = (item - m) * (item - m);
                result[i] = val;
                i++;
            }
            //for (int i = 0; i < values.Length; i++)
            //{
            //    double val = (values[i] - m) * (values[i] - m);
            //    result[i] = val;
            //}
            return MathExpectation(result);
        }


        public static double MathExpectation(IEnumerable<double> values)
        {
            double sum = 0;
            foreach (var value in values)
            {
                sum += value;
            }
            return sum / (double)values.Count();
        }
        public static double MathExpectation<T>(IEnumerable<T> values)
        {
            return MathExpectation(values.Cast<double>());
        }
    }
}
