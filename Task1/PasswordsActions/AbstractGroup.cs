using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.PasswordsActions
{
    public abstract class AbstractGroup
    {
        public List<PasswordAction> passwordActions;
        public abstract List<PasswordAction> GetPasswordActions();
        public void AddChildGroup(AbstractGroup childGroup)
        {

        }
    }
}
