using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1.Forms.Containers
{
    public class Director
    {
        private IBuilder builder;

        public Director(IBuilder builder)
        {
            this.builder = builder;
        }
        public void Make(Control parent)
        {
            IBuilder builder = this.builder.BuildContainer(parent, new GroupBox(), "Днем");
            builder.BuildElement();
            builder.BuildElement();
            builder.BuildElement();
            builder= this.builder.BuildContainer(parent, new GroupBox(), "Вечером");
            builder.BuildElement();
            builder.BuildElement();
            builder.BuildElement();
        }
    }
}
