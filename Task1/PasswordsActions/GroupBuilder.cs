using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.PasswordsActions
{
    public class GroupBuilder:IGroupBuilder
    {
        private AbstractGroup group;

        public GroupBuilder(AbstractGroup group)
        {
            this.group = group;
        }
        public GroupBuilder AppendGroup(Func<PasswordAction, bool> condition)
        {
            AbstractGroup childGroup = new PasswordActionsGroup(group.passwordActions.Where(condition));
            group.(childGroup);
            return new GroupBuilder(childGroup);
        }
        public void AppendGroupLeaf(Func<PasswordAction, bool> condition)
        {
            AbstractGroup childGroup = new PasswordActionGroupLeaf(group.passwordActions.Where(condition));
            group.AddChildGroup(childGroup);
        }
    }
}
