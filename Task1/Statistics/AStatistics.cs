using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.MyMath;

namespace Task1
{
    public abstract class AStatistics<T, V, U>
    {
        protected ObservableCollection<T> Collection { get; private set; }
        protected double MathExpectation { get; set; }
        protected double Dispersion { get; set; }
        protected double Sigma { get; set; }

        public double GetMathExpectation() => MathExpectation;
        public double GetDispersion() => Dispersion;
        public double GetSigma() => Sigma;
        public AStatistics(ObservableCollection<T> collection)
        {
            Collection = collection ?? throw new ArgumentNullException(nameof(collection));
            Collection.CollectionChanged += Collection_CollectionChanged;
            Collection_CollectionChanged();
        }
        public void ChangeCollection(ObservableCollection<T> collection)
        {
            Collection = collection ?? throw new ArgumentNullException(nameof(collection));
            Collection_CollectionChanged();
        }

        protected void Collection_CollectionChanged(object sender = null, NotifyCollectionChangedEventArgs e = null)
        {
            MathExpectation = StatisticsMethods.MathExpectation(ToIEnumerable());
            Dispersion = StatisticsMethods.Dispersion(ToIEnumerable(), MathExpectation);
            Sigma = StatisticsMethods.Sigma(ToIEnumerable(), Dispersion);
        }

        public abstract U this[int index] { get; }
        public abstract IEnumerable<V> ToIEnumerable();

        //public virtual IEnumerator<V> GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}

        //private void setUpPasswordsDurations()
        //{
        //    int count = PasswordActions.Count;
        //    for (int i = 0; i < count; i++)
        //    {
        //        PasswordsDurations[i] = PasswordActions[i].TimeDuration;
        //    }
        //}


        //public IEnumerator GetEnumerator()
        //{
        //    for (int i = 0; i < Collection.Count ; i++)
        //    {
        //        yield return Collection[i].TimeDuration;
        //    }
        //}

        //IEnumerator  IEnumerable.GetEnumerator()
        //{
        //    for (int i = 0; i < Collection.Count; i++)
        //    {
        //        yield return Collection[i];
        //    }
        //}
    }

    public class StatisticsEnumerator<T, V> : IEnumerator<T>
    {
        T[] collection;
        int position = -1;
        public StatisticsEnumerator(T[] collection)
        {
            this.collection = collection;
        }
        public object Current
        {
            get
            {
                return this.Current;
            }
        }

        T IEnumerator<T>.Current
        {
            get
            {
                if (position == -1 || position >= collection.Length)
                    throw new InvalidOperationException();
                return collection[position];
            }
        }

        public void Dispose()
        {

        }

        public bool MoveNext()
        {
            if (position < collection.Length - 1)
            {
                position++;
                return true;
            }
            else
                return false;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
