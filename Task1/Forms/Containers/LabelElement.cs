using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1.Containers
{
    public class LabelElement:IUpdatable
    {
        private string sampleText;
        private readonly Func<double> updaterMethod;
        private readonly Control parent;

        public Label Label { get; protected set; }

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
        }
        public void Update()
        {
            Label.Text = Format(updaterMethod());
        }

        private string Format(double value)
        {
            return sampleText + " : " + Math.Round(value,4).ToString();
        }
    }
}
