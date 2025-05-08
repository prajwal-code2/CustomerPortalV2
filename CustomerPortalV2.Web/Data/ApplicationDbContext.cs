﻿using Microsoft.EntityFrameworkCore;
using CustomerPortalV2.Web.Models;

namespace CustomerPortalV2.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
