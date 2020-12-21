using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.PasswordsActions
{
    public class PasswordActionGroupLeaf:AbstractGroup
    {
        private List<PasswordAction> passwordActions;
        public PasswordActionsGroup(Func<List<PasswordAction>> updater)
        {

        }
    }
}
