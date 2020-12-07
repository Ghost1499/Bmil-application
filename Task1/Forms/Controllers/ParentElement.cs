using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Forms.Controllers
{
    public class ParentElement : IUpdatable
    {
        private List<IUpdatable> children;
        public void Update()
        {
            foreach (var child in children)
            {
                child.Update();
            }
        }
    }
}
