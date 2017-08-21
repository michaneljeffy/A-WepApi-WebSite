using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedBox.Models;
using System.Data.Entity;

namespace RedBox.DLL
{
    public class RedBoxDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        
        public DbSet<UserGroup> UserGroups { get; set; }
        public DbSet<UserConfig> UserConfig { get; set; }
        public RedBoxDbContext()
            : base("DefaultConnection")
        {
            Database.CreateIfNotExists();
        }
    }
}
