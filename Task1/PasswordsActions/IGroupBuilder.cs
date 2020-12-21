using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.PasswordsActions
{
    interface IGroupBuilder
    {
        GroupBuilder AppendGroup(Func<PasswordAction, bool> condition);
        void AppendGroupLeaf(Func<PasswordAction, bool> condition);
    }
}
