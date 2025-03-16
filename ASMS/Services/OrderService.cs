using ASMS.Base.Context;
using ASMS.Base.Entities;
using ASMS.Base.Enums;
using ASMS.Base.Models;
using ASMS.Forms.Abstraction;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMS.Forms.Services
{
    public class OrderService : IEntityService<OrderDTO>
    {
        private readonly ASMSDbContext _context;
        private readonly IMapper _mapper;

        public OrderService(ASMSDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Add(OrderDTO entity)
        {
            bool exist = _context.Orders
                .AsEnumerable()
                .Any(x => x.ClientId == entity.ClientId &&
                          x.CarId == entity.CarId &&
                          x.Services.Any(s => entity.Services.Any(dtoService => dtoService.Id == s.Id)) &&
                          (x.Status == OrderStatus.Created || x.Status == OrderStatus.InProgress));

            if (!exist)
            {
                var order = _mapper.Map<Order>(entity);
    
                order.Services.Clear();

                _context.Orders.Add(order);
                _context.SaveChanges(); 

                var services = _context.Services
                    .Where(s => entity.Services.Select(dto => dto.Id).Contains(s.Id))
                    .ToList();

                var orderServices = services
                    .Select(service => new OrderServices
                    {
                        OrderId = order.Id,
                        ServiceId = service.Id
                    }).ToList();

                _context.OrderServices.AddRange(orderServices);
                _context.SaveChanges();


                MessageBox.Show("Заказ успешно добавлен");
            }
            else
            {
                MessageBox.Show("Такой заказ уже существует");
            }

        }

        public List<OrderDTO> Get()
        {
            var orders = _context.Orders.ToList();

            orders.Select(order => new OrderDTO
            {
                Id = order.Id,
                Description = order.Description,
                OrderDate = order.OrderDate,
                Status = order.Status,
                ClientName = GetClientName(order.ClientId),
                CarInfo = GetCarInfo(order.CarId),
                ClientId = order.ClientId,
                CarId = order.CarId
            }).ToList();


            var orderDTOs = _mapper.Map<List<OrderDTO>>(orders);

            return orderDTOs;

        }

            public void Remove(OrderDTO entity)
            {
                var order = _context.Orders.FirstOrDefault(x => x.Id == entity.Id);
                if (order == null)
                {
                    MessageBox.Show("Заказ не найден");
                    return;
                }

                if (order.Status is OrderStatus.Completed or OrderStatus.InProgress)
                {
                    MessageBox.Show("Ошибка! Невозможно удалить заказ. Возможно, он выполнен или находится в работе.");
                    return;
                }

                _context.Orders.Remove(order);
                _context.SaveChanges();
                MessageBox.Show("Заказ успешно удалён");

            }

            public void UpDate(OrderDTO entity)
            {
                var order = _context.Orders.FirstOrDefault(x => x.Id == entity.Id);
                if (order == null)
                {
                    MessageBox.Show("Заказ не найден");
                    return;
                }

                order.Description = entity.Description;
                order.Status = entity.Status;
                order.CarId = entity.CarId;
                order.ClientId = entity.ClientId;
                order.Services = entity.Services?.Select(s => _mapper.Map<Service>(s)).ToList() ?? new List<Service>();

                _context.SaveChanges();
                MessageBox.Show("Данные успешно обновлены");
            }

            private void AddServiceToOrder(int orderId)
            {

            }
            public string GetClientName(int clientId)
            {
                var client = _context.Clients.FirstOrDefault(c => c.Id == clientId);
                return client?.Name ?? "Не указан";
            }
            public string GetCarInfo(int carId)
            {
                var car = _context.Cars.FirstOrDefault(c => c.Id == carId);
                return car != null ? $"{car.Brand} {car.Model} {car.RegNumber}" : "Не указана";
            }
        
    }
}
