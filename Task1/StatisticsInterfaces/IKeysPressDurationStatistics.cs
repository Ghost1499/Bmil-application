using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.StatisticsInterfaces
{
    public interface IKeysPressDurationStatistics:IStatistics
    {
        void GetKeysPressDurations(out string[] xValues, out double[] yValues);
    }
}
