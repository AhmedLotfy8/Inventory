
using Inventory.Web.Database.Contexts;
using Inventory.Web.Database.Entities;
using Inventory.Web.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Web {
    public class Program {
        public static void Main(string[] args) {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle


            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            builder.Services.AddDbContext<InventoryDbContext>(options => {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });


            //builder.Services.AddIdentityCore<User>()
            //    .AddEntityFrameworkStores<InventoryDbContext>()
            //    .AddApiEndpoints();


            var app = builder.Build();



            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment()) {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();


            using (var scope = app.Services.CreateScope()) {
                
                var dbContext = scope.ServiceProvider.GetRequiredService<InventoryDbContext>();
                var importer = new AiTableCsvImporter(dbContext); 
                
                importer.Import("C:\\Users\\Kimo Store\\Desktop\\DataSet.csv");
 
            }


            app.Run();
        }
    }
}
