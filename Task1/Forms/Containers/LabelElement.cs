using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1.Containers
{
    public class LabelElement : IUpdatable
    {
        private string sampleText;
        private Func<double> updaterMethod;
        private Control parent;

        public Label Label { get; protected set; }
        public object DataSource { get; }
        public string Property { get; }
        public double Value { get; }

        public LabelElement(string sampleText,Func<double> updaterMethod,Control parent)
        {

            this.sampleText = sampleText;
            this.Label = new Label();
            SetUpLabel();
            this.updaterMethod = updaterMethod;
            this.parent = parent;
            parent.Controls.Add(Label);
        }

        protected void SetUpLabel()
        {
            Label.AutoSize = true;
            Label.Font = new System.Drawing.Font(Label.Font.Name, 12);
            Label.Margin = new Padding(10);
            //Binding b = new Binding("Text", DataSource, Property);
            //b.Format += B_Format;

            //Label.DataBindings.Add(b);
        }

        //private void B_Format(object sender, ConvertEventArgs e)
        //{
        //    // The method converts only to string type. Test this using the DesiredType.
        //    if (e.DesiredType != typeof(string)) return;

        //    // Use the ToString method to format the value as currency ("c").
        //    e.Value = $"{sampleText}: {Math.Round((double)e.Value,4)}";
        //}

        public void Update()
        {
            Label.Text = Format(updaterMethod());
        }
        private string Format(double value)
        {
            if (double.IsNaN(value))
                return sampleText + ": Нет";
            return sampleText + " : " + Math.Round(value, 4).ToString();
        }
    }
}
