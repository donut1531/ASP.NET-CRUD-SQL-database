using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using WebAppAndApi.Entities;

namespace WebAppAndApi.Repositories.EfCore
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.SetCommandTimeout((int)TimeSpan.FromMinutes(20).TotalSeconds);
        }
        public DbSet<Entities.ProductMake> ProductMake { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entities.ProductMake>()
                .ToTable("Movie")
                .HasKey(e => e.ProductMovieCode);
        }
    }
}
