﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.main;

namespace Task1
{
    class UserContext : DbContext
    {
        public UserContext() : base("DbConnection")
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
