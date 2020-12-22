using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Statistics
{
    public class PressDurationStatistics : AStatistics<SymbolAction, double, double>, IEnumerable<double>
    {
        public PressDurationStatistics(ObservableCollection<SymbolAction> symbolActions) : base(symbolActions)
        {
        }

        

        public IEnumerator<double> GetEnumerator()
        {
            return new PressDurationStatisticsEnumerator(Collection);
        }

        public override IEnumerable<double> ToIEnumerable()
        {
            IEnumerable<double> enumerable = (IEnumerable<double>)this;
            return enumerable;
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return new PressDurationStatisticsEnumerator(Collection);
        }


    }

    public class PressDurationStatisticsEnumerator : StatisticsEnumerator<SymbolAction, double>, IEnumerator<double>
    {
        public PressDurationStatisticsEnumerator(ObservableCollection<SymbolAction> collection) : base(collection)
        {

        }
        public override object Current
        {
            get
            {
                SymbolAction passwordAction = base.Current as SymbolAction;
                return  FormatY(passwordAction.KeyPressDuration);
            }
        }
        double IEnumerator<double>.Current { get { return (double)this.Current; } }
        protected double FormatY(double value)
        {
            return value;
        }
    }
}
