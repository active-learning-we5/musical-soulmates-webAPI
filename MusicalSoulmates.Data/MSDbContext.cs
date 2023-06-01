using Microsoft.EntityFrameworkCore;
using MusicalSoulmates.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicalSoulmates.Data
{
    public class MSDbContext : DbContext
    {
        public MSDbContext() : base()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<BaseData> BaseData { get; set; }
        public DbSet<BaseDataTranslation> BaseDataTranslations { get; set; }
    }
}
