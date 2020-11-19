using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class HaarFunction
    {
        public static double[] Haar(int N, double t)
        {
            if (N < 0)
                throw new Exception("Wrong parametr N given");
            //int r = 0;
            //int m = 0;
            double[] haarVector = new double[N];
            haarVector[0] = 1;

            int log = Convert.ToInt32(Math.Floor(Math.Log(N, 2)));
            int pow = 1;
            for (int r = 0,count=1; r < log; r++)
            {
                for(int m = 1; m <= pow; m++,count++)
                {
                    haarVector[count] = haar(pow, m, t);
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
            if (t>=((double)(m-1))/pow && t < temp)
            {
                return Math.Sqrt(pow);
            }
            else if(t>= temp && t< (double)m / pow)
            {
                return -Math.Sqrt(pow);
            }
            return 0;
        }
    }
}
