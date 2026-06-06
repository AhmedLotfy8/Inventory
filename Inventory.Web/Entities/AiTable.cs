namespace Inventory.Web.Entities {
    public class AiTable {


        public required int Id { get; set; }

        public DateTime Date { get; set; }

        public required string StoreId { get; set; }

        public required string ProductId { get; set; }

        public string Category { get; set; }

        public string Region { get; set; }

        public int Inventory { get; set; }

        public int UnitsSold { get; set; }
        
        public int UnitsOrdered { get; set; }
        
        public decimal DemandForecast { get; set; }
        
        public decimal Price { get; set; }
        
        public int Discount { get; set; }
        
        public string WeatherCondition { get; set; }
        
        public bool HolidayPromotion { get; set; }
        
        public decimal CompetitorPricing { get; set; }

        public string Seasonality { get; set; }


    }
}
