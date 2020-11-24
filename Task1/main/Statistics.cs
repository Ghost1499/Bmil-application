using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.StatisticsInterfaces;

namespace Task1
{
    public class Statistics: IPasswordsDurationsStatistics, IPasswordDinamicStatistics,IKeysPressDurationStatistics,IPasswordVelocityStatistics
    {
        public List<PasswordAction> PasswordActions { get { return PasswordManager.PasswordActions; } }
        public PasswordAction PasswordAction { get { return PasswordActions.LastOrDefault(); } }

        public PasswordManager PasswordManager { get; }

        public Statistics(PasswordManager passwordManager)
        {
            PasswordManager = passwordManager;
        }


        public double GetPasswordsMathExpectasion()
        {
            return MathExpectation(GetPasswordDurations(PasswordActions));
        }

        public double GetPasswordsDispersion()
        {
            return Dispersion(GetPasswordDurations(PasswordActions));
        }

        public double GetPasswordsSigma()
        {
            return Sigma(GetPasswordDurations(PasswordActions));
        }

        public double GetOverlaysCount()
        {
            PasswordAction passwordAction = PasswordAction;
            return passwordAction.OverlaysCount;

        }


        public double[] GetPasswordsDurations()//исправить long и int
        {
            return GetPasswordDurations(PasswordActions);
        }
        public double[] GetPasswordDurations(List<PasswordAction> passwordActions)//исправить long и int
        {
            double[] result = new double[passwordActions.Count()];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = TimeSpanConverter.TotalSeconds(passwordActions[i].TimeDuration);
            }
            return result;
        }

        public void GetKeysPressDurations(out string[] xValues, out double[] yValues)
        {
            PasswordAction passwordAction = PasswordAction;
            GetKeysPressDuration(passwordAction, out xValues, out yValues);
        }

        protected void GetKeysPressDuration(PasswordAction passwordAction, out string[] typedSymbols, out double[] result)
        {
            int n = passwordAction.SymbolActions.Count();
            result = new double[n];
            for (int i = 0; i < n; i++)
            {
                result[i] = passwordAction.SymbolActions[i].KeyPressDuration;
            }
            typedSymbols = passwordAction.GetTypedSymbols();
        }
        public void GetPasswordTypingDinamic(out string[] xValues, out double[] yValues)
        {
            PasswordAction passwordAction = PasswordAction;
            int n = passwordAction.SymbolActions.Count();
            //xValues = new string[n];
            //yValues = new double[n];
            GetTypingDinamic(passwordAction, out xValues, out yValues);
        }
        protected void GetTypingDinamic(PasswordAction passwordAction,out string[] typedSymbols, out double[] result)
        {
            int n = passwordAction.SymbolActions.Count();
            result = new double[n];
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
            //return result;
        }
        //public double[] GetPressDuration(PasswordAction passwordAction, out string[] typedSymbols)
        //{
        //    int n = passwordAction.SymbolActions.Count();
        //    double[] result = new double[n];
        //    for (int i = 0; i < n; i++)
        //    {
        //        result[i] = passwordAction.SymbolActions[i].KeyPressDuration;
        //    }
        //    typedSymbols = passwordAction.GetTypedSymbols();
        //    return result;
        //}



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

        public double GetPasswordsVelocityMathExpectasion()
        {
            return MathExpectation(GetPasswordsVelocity());
        }

        public double GetPasswordsVelocityDispersion()
        {
            return Dispersion(GetPasswordsVelocity());
        }

        public double GetPasswordsVelocitySigma()
        {
            return Sigma(GetPasswordsVelocity());
        }

        public double[] GetPasswordsVelocity()
        {
            return GetPasswordsVelocity(PasswordActions);
        }
        public double[] GetPasswordsVelocity(List<PasswordAction> passwordActions)
        {
            double[] result = new double[passwordActions.Count()];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = passwordActions[i].ValidPassword.Length/ TimeSpanConverter.TotalSeconds(passwordActions[i].TimeDuration);
            }
            return result;
        }

        public double[] GetPasswordVector()
        {
            return this.PasswordAction.GetBiometricalVector();
        }

    }
}
