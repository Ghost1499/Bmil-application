using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Statistics
{
    public class VelocityStatistics : AStatistics<PasswordAction, double, double>,IEnumerable<double>
    {
        public VelocityStatistics(ObservableCollection<PasswordAction> passwordActions) : base(passwordActions)
        {
        }



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
            return new VelocityStatisticsEnumerator(Collection);
        }
    }

    public class VelocityStatisticsEnumerator : StatisticsEnumerator<PasswordAction, double>, IEnumerator<double>
    {
        public VelocityStatisticsEnumerator(ObservableCollection<PasswordAction> collection) : base(collection)
        {

        }
        public override object Current { get { PasswordAction passwordAction = base.Current as PasswordAction;
                return passwordAction.ValidPassword.Count() / FormatY(passwordAction.TimeDuration); } }
        double IEnumerator<double>.Current { get { return (double)this.Current; } }
        protected double FormatY(double value)
        {
            return TimeSpanConverter.TotalSeconds(value);
        }
    }
}
