﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task1.Containers;

namespace Task1.Forms.Containers
{
    public interface IBuilder
    {
        void Reset();
        void BuildElement(string sampleText,object dataSource, string property, Control parent);
        IBuilder BuildContainer(Control parent, GroupBox element = null, string elementText = null);
        LabelsContainer GetResult();
    }
}
