using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class PasswordActionBuilder
    {
        public PasswordAction ConstructPasswordAction(string validPassword, DateTime startTime)
        {
            PasswordAction passwordAction = new PasswordAction();
            if (string.IsNullOrEmpty(validPassword))
            {
                throw new ArgumentException("message", nameof(validPassword));
            }
            passwordAction.ValidPassword = validPassword;
            passwordAction.StartTime = startTime;
            passwordAction.EndTime = passwordAction.StartTime;
            return passwordAction;
        }
    }
}
