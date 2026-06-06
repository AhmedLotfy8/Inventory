using Inventory.Web.Database.Entities;
using Inventory.Web.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Inventory.Web.Database.Contexts {
    public class InventoryDbContext : DbContext {

        public InventoryDbContext(DbContextOptions options) : base(options) {
            
        }

        DbSet<AiTable> AiTables { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);

        }


    }
}
