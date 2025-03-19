
using ASMS.API.Abstraction;
using ASMS.API.Services;
using ASMS.Base.Context;
using ASMS.Base.Mapper;
using Microsoft.EntityFrameworkCore;

namespace ASMS.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var configuration = new ConfigurationBuilder()
            .SetBasePath(@"C:\Users\jiejo\source\repos\ASMS\ASMS.Base") 
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

            var connectionString = configuration.GetConnectionString("db");

            builder.Services.AddSingleton(connectionString);
            builder.Services.AddDbContext<ASMSDbContext>((serviceProvider, options) =>
                    options.UseNpgsql(serviceProvider.GetRequiredService<string>())
                );

            builder.Services.AddAutoMapper(typeof(MapperProfile));
            builder.Services.AddScoped<IManageOrdersService, ManageOrdersService>();
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}
