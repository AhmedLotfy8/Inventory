using Inventory.Web.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Inventory.Web.Database.Configurations {
    public class AiTableConfiguration : IEntityTypeConfiguration<AiTable> {
        public void Configure(EntityTypeBuilder<AiTable> builder) {


            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd();

            #region 5

            builder.Property(x => x.Date)
                .HasColumnType("date");

            builder.Property(x => x.StoreId)
                .IsRequired().HasMaxLength(50);

            builder.Property(x => x.ProductId)
                .IsRequired().HasMaxLength(50);

            builder.Property(x => x.Category)
                .HasMaxLength(100);

            builder.Property(x => x.Region)
                .HasMaxLength(100);


            #endregion


            #region 10

            builder.Property(x => x.Inventory)
                .HasColumnType("int");

            builder.Property(x => x.UnitsSold)
                .HasColumnType("int");

            builder.Property(x => x.UnitsOrdered)
                .HasColumnType("int");

            builder.Property(x => x.DemandForecast)
                .HasColumnType("decimal(18,2)");

            builder.Property(x => x.Price)
                .HasColumnType("decimal(18,2)");

            #endregion



            #region 15

            builder.Property(x => x.Discount)
                .HasColumnType("int");

            builder.Property(x => x.WeatherCondition)
                .HasMaxLength(100);

            builder.Property(x => x.HolidayPromotion)
                .HasColumnType("bit");

            builder.Property(x => x.CompetitorPricing)
                .HasColumnType("decimal(18,2)");

            builder.Property(x => x.Seasonality)
                .HasMaxLength(100);

            #endregion


            



        }

    }
}
