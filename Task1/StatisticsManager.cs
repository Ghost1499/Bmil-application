using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class StatisticsManager
    {
        public List<PasswordAction> PasswordActions { get; set; }
        public PasswordAction PasswordAction { get { return PasswordActions.Last(); } }

        public StatisticsManager(List<PasswordAction> passwordActions)
        {
            if (passwordActions == null)
            {
                throw new ArgumentNullException(nameof(passwordActions));
            }

            PasswordActions = passwordActions;
        }


        public double GetPasswordsMathExpectasion(double[] passwordDurations)
        {
            return MathExpectation(passwordDurations);
        }

        public double GetPasswordsDispersion(double[] passwordDurations)
        {
            return Dispersion(passwordDurations);
        }

        public double GetPasswordsSigma(double[] passwordDurations)
        {
            return Sigma(passwordDurations);
        }
        public double[] GetPasswordDurations(List<PasswordAction> passwordActions)//исправить long и int
        {
            double[] result = new double[passwordActions.Count()];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = passwordActions[i].TimeDuration;
            }
            return result;
        }

        public double[] GetTypingDinamic(PasswordAction passwordAction,out string[] typedSymbols)
        {
            int n = passwordAction.SymbolActions.Count();
            double[] result = new double[n];
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
        public double[] GetPressDuration(PasswordAction passwordAction, out string[] typedSymbols)
        {
            int n = passwordAction.SymbolActions.Count();
            double[] result = new double[n];
            for (int i = 0; i < n; i++)
            {
                result[i] = passwordAction.SymbolActions[i].KeyPressDuration;
            }
            typedSymbols = passwordAction.GetTypedSymbols();
            return result;
        }

        public static double Sigma<T>(T[] values)
        {
            return Sigma(values.Cast<double>().ToArray());
        }

        public static double Sigma(double[] values)
        {
            return Math.Pow(Dispersion(values), (double)0.5);
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
