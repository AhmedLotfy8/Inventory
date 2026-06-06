using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using Inventory.Web.Entities;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Web.Services {
    public class AiTableCsvImporter {
        private readonly DbContext _dbContext;

        public AiTableCsvImporter(DbContext dbContext) {
            _dbContext = dbContext;
        }

        public void Import(string filePath) {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture) {
                HasHeaderRecord = true,
                Delimiter = ","
            };

            using var reader = new StreamReader(filePath);
            using var csv = new CsvReader(reader, config);

            csv.Context.RegisterClassMap<AiTableMap>();

            var records = csv.GetRecords<AiTable>().ToList();


            _dbContext.Set<AiTable>().AddRange(records);
            _dbContext.SaveChanges();
        }
    }
}
