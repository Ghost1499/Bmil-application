using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.PasswordsActions
{
    public class PasswordActionsGroup:AbstractGroup
    {
        IEnumerable<PasswordAction> passwordActions;
        List<AbstractGroup> childGroups;
        public PasswordActionsGroup(IEnumerable<PasswordAction> passwordActions)
        {

        }

        public override List<PasswordAction> GetPasswordActions()
        {
            List<PasswordAction> passwordActions=new List<PasswordAction>()
            return childGroups
        }
    }
}
