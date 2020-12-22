using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Statistics
{
    public class TypingDinamicStatistics : AStatistics<SymbolAction, double, double>, IEnumerable<double>
    {
        public TypingDinamicStatistics(ObservableCollection<SymbolAction> symbolActions) : base(symbolActions)
        {
        }



        public IEnumerator<double> GetEnumerator()
        {
            return new TypingDinamicStatisticsEnumerator(Collection);
        }

        public override IEnumerable<double> ToIEnumerable()
        {
            IEnumerable<double> enumerable = (IEnumerable<double>)this;
            return enumerable;
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return new TypingDinamicStatisticsEnumerator(Collection);
        }


    }

    public class TypingDinamicStatisticsEnumerator : StatisticsEnumerator<SymbolAction, double>, IEnumerator<double>
    {
        public TypingDinamicStatisticsEnumerator(ObservableCollection<SymbolAction> collection) : base(collection)
        {

        }
        public override object Current
        {
            get
            {
                SymbolAction symbolAction = base.Current as SymbolAction;

                double result;
                if ( position < 1)
                {
                    result = symbolAction.KeyDownTime;
                }
                else
                {
                    result = symbolAction.KeyDownTime - collection[position - 1].KeyDownTime;
                }
                return FormatY(result);
            }
        }
        double IEnumerator<double>.Current { get { return (double)this.Current; } }
        protected double FormatY(double value)
        {
            return value;
        }
    }
}
