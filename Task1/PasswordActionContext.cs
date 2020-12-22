using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Task1.main;

namespace Task1
{
    public class PasswordActionContext:DbContext
    {
        public PasswordActionContext() : base("DbConnection")
        {

        }

        public DbSet<PasswordAction> PasswordActions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<SymbolAction> SymbolActions { get; set; }

    }
}
