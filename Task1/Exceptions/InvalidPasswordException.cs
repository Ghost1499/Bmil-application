using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Exceptions
{
    [Serializable]
    class InvalidPasswordException :BaseException
    {
        private string wrongPassword;

        public string WrongPassword { get => wrongPassword; set => wrongPassword = value; }

        public InvalidPasswordException():base() { }

        public InvalidPasswordException(string message) : base(message) { }

        public InvalidPasswordException(string message, Exception inner) : base(message, inner) { }


        protected InvalidPasswordException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            if (info != null)
            {
                this.wrongPassword = info.GetString("WrongPassword");
            }
        }
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);

            info.AddValue("WrongPassword", this.WrongPassword);
        }
    }
}
