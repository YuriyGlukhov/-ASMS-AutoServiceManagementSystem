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
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Настроим конфигурацию для получения строки подключения
            var configuration = new ConfigurationBuilder()
                .SetBasePath(@"C:\Users\jiejo\source\repos\ASMS\ASMS.Base")  // Путь к файлу конфигурации
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            // Получаем строку подключения
            var connectionString = configuration.GetConnectionString("db");

            // Настроим контейнер зависимостей
            var serviceProvider = new ServiceCollection()
                .AddSingleton(connectionString)  // Регистрируем строку подключения как Singleton
                .AddScoped<IEntityService<ClientDTO>, ClientService>()
                .AddScoped<IEntityService<CarDTO>, CarService>()
                .AddScoped<IEntityService<OrderDTO>, OrderService>()
                .AddScoped<IEntityService<ServiceDTO>, ServiceService>()
                .AddScoped<MainMenu>()  // Регистрируем MainMenu
                .AddDbContext<ASMSDbContext>((serviceProvider, options) =>
                    options.UseNpgsql(serviceProvider.GetRequiredService<string>())  // Получаем строку подключения из DI
                )
                .AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies())
                .BuildServiceProvider();

            // Запускаем приложение
            ApplicationConfiguration.Initialize();
            Application.Run(serviceProvider.GetRequiredService<MainMenu>());
        }
    }
}