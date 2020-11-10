using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.StatisticsInterfaces
{
    public interface IPasswordsDurationsStatistics:IStatistics
    {
        double GetPasswordsMathExpectasion();
        double GetPasswordsDispersion();
        double GetPasswordsSigma();
        double[] GetPasswordsDurations();
    }
}
