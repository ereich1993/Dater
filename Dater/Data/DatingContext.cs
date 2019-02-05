using Dater.Models;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dater
{
    public class DatingContext : DbContext
    {
        public DatingContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Entity> entities { get; set; }
        public DbSet<User>users { get; set; }
        public DbSet<MenuItems>menuItems { get; set; }
        public DbSet<MenuUser> menuUsers { get; set; }
    }
}
