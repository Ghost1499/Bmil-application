using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.StatisticsInterfaces
{
    public interface IPasswordDinamicStatistics:IStatistics
    {
        double GetOverlaysCount();
        void GetPasswordTypingDinamic(out string[] xValues, out double[] yValues);
    }
}
