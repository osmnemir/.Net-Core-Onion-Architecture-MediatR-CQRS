﻿using Microsoft.EntityFrameworkCore;
using ProductApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Persistence.Context
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product() { Id = Guid.NewGuid(), Name = "Pencil", Value = 10, Quantity = 30 },
                new Product() { Id = Guid.NewGuid(), Name = "Paper", Value = 1, Quantity = 80 },
                new Product() { Id = Guid.NewGuid(), Name = "Book", Value = 30, Quantity = 87 }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
