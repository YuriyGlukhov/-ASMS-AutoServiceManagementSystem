using ASMS.Base.Context;
using ASMS.Base.Models;
using ASMS.Forms.Abstraction;
using ASMS.Forms.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ASMS.Forms
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(@"C:\Users\jiejo\source\repos\ASMS\ASMS.Base")  
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            var connectionString = configuration.GetConnectionString("db");

            var serviceProvider = new ServiceCollection()?
                .AddSingleton(connectionString)  
                .AddScoped<IEntityService<ClientDTO>, ClientService>()
                .AddScoped<IEntityService<CarDTO>, CarService>()
                .AddScoped<IEntityService<OrderDTO>, OrderService>()
                .AddScoped<IEntityService<ServiceDTO>, ServiceService>()
                .AddScoped<IClientsCarService, ClientsCarService>()
                .AddScoped<MainMenu>()  
                .AddDbContext<ASMSDbContext>((serviceProvider, options) =>
                    options.UseNpgsql(serviceProvider.GetRequiredService<string>())
                )
                .AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies())
                .BuildServiceProvider();

            // Запускаем приложение
            ApplicationConfiguration.Initialize();
            Application.Run(serviceProvider.GetRequiredService<MainMenu>());
        }
    }
}