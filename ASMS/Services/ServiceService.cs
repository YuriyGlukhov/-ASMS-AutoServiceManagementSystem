using ASMS.Base.Context;
using ASMS.Base.Entities;
using ASMS.Base.Models;
using ASMS.Forms.Abstraction;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMS.Forms.Services
{
    public class ServiceService : IEntityService<ServiceDTO> 
    {
        private readonly ASMSDbContext _context;
        private readonly IMapper _mapper;

        public ServiceService(ASMSDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Add(ServiceDTO entity)
        {
            bool exist = _context.Services.Any(x => x.Id == entity.Id &&
                                        x.Name == entity.Name &&
                                        x.Price == entity.Price);
            if (!exist)
            {
                var service = _mapper.Map<Service>(entity);
                _context.Services.Add(service);
                _context.SaveChanges();
                MessageBox.Show("Услуга успешно добавлена");
            }
            else
            {
                MessageBox.Show("Такая услуга уже существует");
            }
        }

        public List<ServiceDTO> Get()
        {
            var services = _context.Services.Select(x => _mapper.Map<ServiceDTO>(x)).ToList();
            return services;
        }

        public void Remove(ServiceDTO entity)
        {
            var service = _context.Services.FirstOrDefault(x => x.Id == entity.Id);
            if (service != null)
            {
                _context.Services.Remove(service);
                _context.SaveChanges();
                MessageBox.Show("Услуга успешно удалена");
            }
            else
            {
                MessageBox.Show("Услуга не найдена");
            }
        }

        public void UpDate(ServiceDTO entity)
        {
            var service = _context.Services.FirstOrDefault(x => x.Id == entity.Id);
            if (service != null)
            {
                _mapper.Map(entity, service);
                _context.SaveChanges();
                MessageBox.Show("Данные успешно обновлены");

            }
            else
            {
                MessageBox.Show("Услуга не найдена");
            }
        }
    }
}
