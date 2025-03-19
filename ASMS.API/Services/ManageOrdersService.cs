using ASMS.API.Abstraction;
using ASMS.Base.Context;
using ASMS.Base.Entities;
using ASMS.Base.Enums;
using ASMS.Base.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ASMS.API.Services
{
    public class ManageOrdersService : IManageOrdersService
    {
        private readonly ASMSDbContext _context;
        private readonly IMapper _mapper;
        private List<ServiceDTO> servicesList = new List<ServiceDTO>();

        public ManageOrdersService(ASMSDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;   
        }
        public OrderResponseDTO CreateNewOrder(string clientName, string clientPhone, string vin, int serviceId)
        {
            servicesList.Clear();

            var client = ClientCheck(clientName, clientPhone);
            var car = CarCheck(vin);
            var service = _context.Services.AsNoTracking().FirstOrDefault(s => s.Id == serviceId);

            if (!servicesList.Any(s => s.Id == service.Id))
            {
                var serviceDTO = _mapper.Map<ServiceDTO>(service);
                servicesList.Add(serviceDTO);
            }
            var orderDTO = new OrderDTO()
            {
                ClientId = client.Id,
                CarId = car.Id,
                OrderDate = DateTime.Now.ToUniversalTime(),
                Status = OrderStatus.Created, 
            };

            var order = _mapper.Map<Order>(orderDTO);

            _context.Orders.Add(order);
            _context.SaveChanges(); 

            orderDTO = _mapper.Map<OrderDTO>(order);

            var orderServices = servicesList.Select(serviceDTO => new OrderServices
            {
                OrderId = order.Id,
                ServiceId = serviceDTO.Id
            }).ToList();

            _context.OrderServices.AddRange(orderServices);
            _context.SaveChanges();

            var response = new OrderResponseDTO()
            {
                OrderId = orderDTO.Id,
                ClientName = client.Name,
                ClientPhone = client.Phone,
                ServiceName = service.Name,
                Price = service.Price
            };

            return response;

        }

        public List<ServiceDTO> GetServicesByCarBrand(string carBrand)
        {
            var services = _context.Services.Select(x => _mapper.Map<ServiceDTO>(x)).ToList();
            foreach (var service in services)
            {
                if(service.CarBrand.ToLower() == carBrand.ToLower() || service.CarBrand.ToLower() == "All".ToLower())
                {
                  servicesList.Add(service); 
                }
            }
            return servicesList;
        }

        public ClientDTO ClientCheck(string name, string phone)
        {
            var client = _context.Clients.FirstOrDefault(x => x.Name == name && x.Phone == phone);

            if (client != null)
            {
                var clientDTO = _mapper.Map<ClientDTO>(client);
                return clientDTO;
            }
            else
            {
                var clientDTO = new ClientDTO()
                {
                    Name = name,
                    Phone = phone
                };
                client = _mapper.Map<Client>(clientDTO);

                _context.Clients.Add(client);
                _context.SaveChanges();

                clientDTO = _mapper.Map<ClientDTO>(client);
                return clientDTO;
            }
        }

        public CarDTO CarCheck(string vin)
        {
            var car = _context.Cars.FirstOrDefault(x => x.Vin == vin);
            if (car != null)
            {
                var carDTO = _mapper.Map<CarDTO>(car);
                return carDTO;
            }
            else
            {
                var carDTO = new CarDTO()
                {
                   Brand = string.Empty,
                   Model = string.Empty,
                   Vin = vin,
                   RegNumber = string.Empty, 
                   Year = 0
                };

                car = _mapper.Map<Car>(carDTO);
                _context.Cars.Add(car);
                _context.SaveChanges();
                carDTO = _mapper.Map<CarDTO>(car);  
                return carDTO;
            }
        }

    }
}
