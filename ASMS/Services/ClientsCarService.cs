using ASMS.Base.Context;
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
    public class ClientsCarService : IClientsCarService
    {
        private readonly ASMSDbContext _context;
        private readonly IMapper _mapper;

        public ClientsCarService(ASMSDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;   
        }
        public void AddCarToClient(int clientId, int carId)
        {
            var client = _context.Clients.Include(c => c.Cars).FirstOrDefault(c => c.Id == clientId);
            var car = _context.Cars.FirstOrDefault(c => c.Id == carId);

            if (client == null || car == null)
            {
                MessageBox.Show("Клиент или машина не найдены!");
                return;
            }
            if (!client.Cars.Any(c => c.Id == carId))
            {
                client.Cars.Add(car);
                _context.SaveChanges();
                MessageBox.Show("Машина успешно привязана к клиенту.");
            }
            else
            {
                MessageBox.Show("Эта машина уже привязана к клиенту.");
            }
        }

        public List<CarDTO> GetClientCars(int clientId)
        {
            var cars = _context.Clients
            .Where(c => c.Id == clientId)
            .Include(c => c.Cars)
            .SelectMany(c => c.Cars)
            .ToList();

            return _mapper.Map<List<CarDTO>>(cars);
        }

        public void RemoveCarFromClient(int clientId, int carId)
        {
            var client = _context.Clients.Include(c => c.Cars).FirstOrDefault(c => c.Id == clientId);
            var car = _context.Cars.FirstOrDefault(c => c.Id == carId);

            if (client == null || car == null)
            {
                MessageBox.Show("Клиент или машина не найдены!");
                return;
            }

            if (client.Cars.Any(c => c.Id == carId))
            {
                client.Cars.Remove(car);
                _context.SaveChanges();
                MessageBox.Show("Машина успешно отвязана от клиента.");
            }
            else
            {
                MessageBox.Show("Эта машина не привязана к клиенту.");
            }
        }
    }
}
