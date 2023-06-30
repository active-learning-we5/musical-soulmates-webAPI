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
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-FDV7DG9;Database=SoulmatesDB;User Id=sa;Password=2580;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BaseData>()
        .HasKey(bd => bd.Id);

            modelBuilder.Entity<BaseData>()
                .HasMany(bd => bd.BaseDataTranslations)
                .WithOne(bdt => bdt.BaseData)
                .HasForeignKey(bdt => bdt.BaseDataId);
        }

        public DbSet<BaseData> BaseData { get; set; }
        public DbSet<BaseDataTranslation> BaseDataTranslations { get; set; }
    }
}
