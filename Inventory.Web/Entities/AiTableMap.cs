using CsvHelper.Configuration;
using Inventory.Web.Entities;

public sealed class AiTableMap : ClassMap<AiTable> {
    public AiTableMap() {
        Map(m => m.Date).Name("Date");
        Map(m => m.StoreId).Name("Store ID");
        Map(m => m.ProductId).Name("Product ID");
        Map(m => m.Category).Name("Category");
        Map(m => m.Region).Name("Region");
        Map(m => m.Inventory).Name("Inventory Level");
        Map(m => m.UnitsSold).Name("Units Sold");
        Map(m => m.UnitsOrdered).Name("Units Ordered");
        Map(m => m.DemandForecast).Name("Demand Forecast");
        Map(m => m.Price).Name("Price");
        Map(m => m.Discount).Name("Discount");
        Map(m => m.WeatherCondition).Name("Weather Condition");
        Map(m => m.HolidayPromotion).Name("Holiday/Promotion");
        Map(m => m.CompetitorPricing).Name("Competitor Pricing");
        Map(m => m.Seasonality).Name("Seasonality");

    }
}
