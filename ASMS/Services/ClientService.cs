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
    public class ClientService : IEntityService<ClientDTO>
    {
        private readonly ASMSDbContext _context;
        private readonly IMapper _mapper;

        public ClientService(ASMSDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Add(ClientDTO entity)
        {
            bool exist = _context.Clients.Any(x => x.Name == entity.Name &&
                                            x.BirthDay == entity.BirthDay &&
                                            x.Phone == entity.Phone);
            if (!exist)
            {
                var client = _mapper.Map<Client>(entity);
                _context.Clients.Add(client);
                _context.SaveChanges();
                MessageBox.Show("Клиент успешно добавлен");
            }
            else
            {
                MessageBox.Show("Такой клиент уже существует");
            }

        }

        public List<ClientDTO> Get()
        {
            var clients = _context.Clients.Select(x => _mapper.Map<ClientDTO>(x)).ToList();
            foreach (var client in clients)
            {
                client.BirthDay = client.BirthDay.Date;
            }
            return clients;

        }

        public void Remove(ClientDTO entity)
        {
            var client = _context.Clients.FirstOrDefault(x => x.Id == entity.Id);
            if (client != null)
            {
                _context.Clients.Remove(client);
                _context.SaveChanges();
                MessageBox.Show("Клиент успешно удалён");
            }
            else
            {
                MessageBox.Show("Клиент не найден");
            }
        }

        public void UpDate(ClientDTO entity)
        {
            try
            {
                var client = _context.Clients.FirstOrDefault(x => x.Id == entity.Id);
                if (client != null)
                {
                    _mapper.Map(entity, client);

                    _context.SaveChanges();

                    MessageBox.Show("Данные успешно обновлены");
                }
                else
                {
                    MessageBox.Show("Клиент не найден");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении данных: {ex.Message}");
            }
        }
    }
}
