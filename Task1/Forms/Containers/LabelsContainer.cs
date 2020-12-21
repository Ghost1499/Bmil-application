using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1.Containers
{
    public class LabelsContainer /*: IUpdatable*/
    {
        private List<Object> children;
        private Control parent;
        private GroupBox element;
        private  string elementText;

        public LabelsContainer(Control parent,GroupBox element=null, string elementText=null, List<Object> children=null)
        {
            if (children == null)
            {
                this.children = new List<Object>();
            }
            else
            {
                this.children = children;

            }

            this.parent = parent;
            this.element = element;
            this.elementText = elementText;
            setUp();
            
        }
        private void setUp()
        {
            if (element != null)
            {
                element.Text = elementText;
                parent.Controls.Add(element);
               
            }
        }

        public void AddChildren(List<Object> children)
        {
            if(children!=null)
                this.children.AddRange(children);
        }
        public void AddChild(Object child)
        {
            if (child != null)
                this.children.Add(child);
        }
        //public void Update()
        //{
        //    foreach (var child in children)
        //    {
        //        child.Update();
        //    }
        //}
    }
}
