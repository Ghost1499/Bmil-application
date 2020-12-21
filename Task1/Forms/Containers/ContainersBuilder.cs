using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task1.Containers;

namespace Task1.Forms.Containers
{
    public class ContainersBuilder : IBuilder
    {
        LabelsContainer container;
        public void Reset()
        {
            
        }
        public ContainersBuilder(LabelsContainer container)
        {
            this.container = container;
        }
        public IBuilder BuildContainer(Control parent, GroupBox element = null, string elementText = null)
        {
            LabelsContainer container = new LabelsContainer(parent, element, elementText);
            this.container.AddChild(container);
            return new ContainersBuilder(container);
        }


        public void BuildElement(string sampleText, object dataSource, string property, Control parent)
        {
            this.container.AddChild(new LabelElement(sampleText,dataSource,property,parent));
        }

        public LabelsContainer GetResult()
        {
            return this.container;
        }

       
    }
}
