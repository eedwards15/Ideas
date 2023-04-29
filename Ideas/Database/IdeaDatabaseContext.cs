using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class IdeaDatabaseContext : DbContext
    {
        public IdeaDatabaseContext(DbContextOptions options) : base(options) { }

        public DbSet<Core.Database.Idea> Ideas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        
        }
    }
}
