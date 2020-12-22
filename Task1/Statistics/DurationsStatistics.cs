using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class DurationsStatistics : AStatistics<PasswordAction,double,double>,IEnumerable<double>
    {

        public DurationsStatistics(ObservableCollection<PasswordAction> passwordActions) : base(passwordActions)
        {
        }

        //public override double this[int index]
        //{
        //    get { return Collection.ElementAt(index).TimeDuration; }
        //}

        public IEnumerator<double> GetEnumerator()
        {
            return new DurationStatisticsEnumerator(Collection);
        }

        public override IEnumerable<double> ToIEnumerable()
        {
            IEnumerable<double> enumerable = (IEnumerable<double>)this;
            return enumerable;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new DurationStatisticsEnumerator(Collection);
        }

        //public IEnumerator GetEnumerator()
        //{
        //    for (int i = 0; i < Collection.Count; i++)
        //    {
        //        yield return TimeSpanConverter.TotalSeconds(Collection[i].TimeDuration);
        //    }
        //}

        //IEnumerator<double> IEnumerable<double>.GetEnumerator()
        //{
        //    for (int i = 0; i < Collection.Count; i++)
        //    {
        //        yield return TimeSpanConverter.TotalSeconds(Collection[i].TimeDuration);
        //    }
        //}
    }

    public class DurationStatisticsEnumerator : StatisticsEnumerator<PasswordAction,double>,IEnumerator<double>
    {
        public DurationStatisticsEnumerator(ObservableCollection<PasswordAction> collection):base(collection)
        {

        }
        public override object Current { get { return FormatY(((PasswordAction)base.Current).TimeDuration); } }
        double IEnumerator<double>.Current { get { return (double)this.Current; } }
        protected  double FormatY(double value)
        {
            return TimeSpanConverter.TotalSeconds(value);
        }
    }
}
