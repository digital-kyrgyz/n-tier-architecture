﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;

namespace NLayer.Repository.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = 1, CategoryId = 1, Name = "Pencil 1", Price = 100, Stock = 20, CreatedDate = DateTime.Now },
                  new Product { Id = 2, CategoryId = 1, Name = "Pencil 2", Price = 200, Stock = 20, CreatedDate = DateTime.Now },
                     new Product { Id = 3, CategoryId = 1, Name = "Pencil 3", Price = 300, Stock = 20, CreatedDate = DateTime.Now },
                         new Product { Id = 4, CategoryId = 2, Name = "Book 1", Price = 500, Stock = 20, CreatedDate = DateTime.Now },
                            new Product { Id = 5, CategoryId = 2, Name = "Book 2", Price = 1000, Stock = 20, CreatedDate = DateTime.Now });
        }
    }
}
