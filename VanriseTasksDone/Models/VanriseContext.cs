using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace VanriseTask34.Models
{
    public class VanriseContext : DbContext
    {
        public VanriseContext()
        {

        }
        public VanriseContext(DbContextOptions<VanriseContext> options) : base(options)
        {
        }
        public virtual DbSet<Device> Devices { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server = LAPTOP-IQGVBR7N\\SQLEXPRESS; Database = VanriseTask; Trusted_Connection = True; Encrypt = False;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Device>(entity =>
            {
                entity.HasKey(e => e.Id);
            }); ;
        }
    }
}