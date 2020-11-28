using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class HaarFunction
    {
        public static Func<double, double>[] HaarVector(int N/*, double t*/)
        {
            if (N < 0)
                throw new Exception("Wrong parametr N given");
            //double[] haarVector = new double[N];
            Func<double, double>[] haarVector = new Func<double, double>[N];
            haarVector[0] = (double t) => 1;

            int log = Convert.ToInt32(Math.Floor(Math.Log(N, 2)));
            int pow = 1;
            for (int r = 0, count = 1; r < log; r++)
            {
                for (int m = 1; m <= pow; m++, count++)
                {
                    int local_pow = pow;
                    int local_m = m;
                    haarVector[count] = (double t) => haar(local_pow, local_m, t);
                }
                pow *= 2;
            }

            return haarVector;
        }

        //pow=2^r
        private static double haar(int pow, int m, double t)
        {
            if (t < 0 || t >= 1)
                throw new Exception("Wrong time t parametr");
            double temp = ((double)m - 0.5) / pow;
            if (t >= ((double)(m - 1)) / pow && t < temp)
            {
                return Math.Sqrt(pow);
            }
            else if (t >= temp && t < (double)m / pow)
            {
                return -Math.Sqrt(pow);
            }
            return 0;
        }
    }
}
