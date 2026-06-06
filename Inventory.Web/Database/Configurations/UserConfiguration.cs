using Inventory.Web.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Inventory.Web.Database.Configurations {
    public class UserConfiguration {


        public void Configure(EntityTypeBuilder<User> builder) {

            //builder.Property(u => u.UserName)
            //    .HasColumnType("nvarchar")
            //    .HasMaxLength(256);

            //builder.Property(u => u.Status)
            //    .HasColumnType("varchar")
            //    .HasMaxLength(256);


        }


    }
}
