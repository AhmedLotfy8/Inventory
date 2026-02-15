using Inventory.Domain.Entities.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Persistence.Data.Configurations {
    public class ProductConfigurations : IEntityTypeConfiguration<Product> {
        
        public void Configure(EntityTypeBuilder<Product> builder) {

            builder.Property(p => p.Name).HasColumnType("varchar").HasMaxLength(256);
            builder.Property(p => p.Description).HasColumnType("varchar").HasMaxLength(500);
            builder.Property(p => p.Price).HasColumnType("decimal(18,2)");
            builder.Property(p => p.QuantityInStock).HasColumnType("int");
            builder.Property(p => p.CreatedAt).HasColumnType("datetime2");
            builder.Property(p => p.UpdatedAt).HasColumnType("datetime2");

        
            builder.HasOne(p => p.Category)
                .WithMany()
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.NoAction);
            
            builder.HasOne(p => p.Supplier)
                .WithMany()
                .HasForeignKey(p => p.SupplierId)
                .OnDelete(DeleteBehavior.NoAction);


        }

    }
}
