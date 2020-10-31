using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Task1
{
    class PasswordActionContext:DbContext
    {
        public PasswordActionContext() : base("DbConnection")
        {

        }

        public DbSet<PasswordAction> PasswordActions { get; set; }
    }
}
