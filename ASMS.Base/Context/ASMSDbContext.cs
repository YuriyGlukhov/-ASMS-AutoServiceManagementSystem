using ASMS.Base.Entities;
using ASMS.Base.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMS.Base.Context
{
    public class ASMSDbContext : DbContext
    {
        private readonly string _connectionString;

        public DbSet<Client> Clients { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<OrderServices> OrderServices { get; set; }

        public ASMSDbContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
   
            optionsBuilder.UseNpgsql(_connectionString)
                    .UseLazyLoadingProxies();
        
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Установка первичных ключей
            modelBuilder.Entity<Client>().HasKey(c => c.Id);
            modelBuilder.Entity<Car>().HasKey(c => c.Id);
            modelBuilder.Entity<Order>().HasKey(o => o.Id);
            modelBuilder.Entity<Service>().HasKey(s => s.Id);

            // Установка внешних ключей
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Client)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.ClientId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Car)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.CarId)
                .OnDelete(DeleteBehavior.Restrict);

            // Настройка свойств
            modelBuilder.Entity<Client>()
                .Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(200);

            modelBuilder.Entity<Car>()
                .Property(c => c.RegNumber)
                .IsRequired()
                .HasMaxLength(20);

            modelBuilder.Entity<Service>()
                .Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Order>()
                .Property(o => o.Description)
                .HasMaxLength(500);

            // Связь Client - Car (один ко многим)
            modelBuilder.Entity<Client>()
                .HasMany(c => c.Cars)
                .WithMany(car => car.Clients);

            // Связь Order - Service (многие ко многим)
            modelBuilder.Entity<Order>()
                .HasMany(o => o.Services)
                .WithMany(s => s.Orders)
                .UsingEntity<OrderServices>(
                    j => j.HasOne(os => os.Service).WithMany().HasForeignKey(os => os.ServiceId),
                    j => j.HasOne(os => os.Order).WithMany().HasForeignKey(os => os.OrderId)
                );

            // Настройка хранения Enum OrderStatus в базе данных как строки
            modelBuilder.Entity<Order>()
                .Property(o => o.Status)
                .HasConversion<string>();
        }

    
    }
}
