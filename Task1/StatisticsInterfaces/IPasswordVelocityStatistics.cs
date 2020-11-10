using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.StatisticsInterfaces
{
    public interface IPasswordVelocityStatistics:IStatistics
    {
        double GetPasswordsVelocityMathExpectasion();
        double GetPasswordsVelocityDispersion();
        double GetPasswordsVelocitySigma();
        double[] GetPasswordsVelocity();
    }
}
