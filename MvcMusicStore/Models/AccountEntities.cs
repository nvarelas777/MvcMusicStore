﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcMusicStore.Models
{
    public class AccountEntities : DbContext
    {
        public DbSet<UserAccount> UserAccounts { get; set; }
    }
}