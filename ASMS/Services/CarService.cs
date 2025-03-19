using ASMS.Forms.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASMS.Base;
using ASMS.Base.Models;
using ASMS.Base.Context;
using AutoMapper;
using ASMS.Base.Entities;

namespace ASMS.Forms.Services
{
    public class CarService : IEntityService<CarDTO>
    {

        private readonly ASMSDbContext _context;
        private readonly IMapper _mapper;

        public CarService(ASMSDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;   
        }

        public void Add(CarDTO entity)
        {
            bool exist = _context.Cars.Any(x => x.RegNumber == entity.RegNumber &&
                                        x.Brand == entity.Brand &&
                                        x.Model == entity.Model);
            if (!exist)
            {
                var car = _mapper.Map<Car>(entity);
                _context.Cars.Add(car);
                _context.SaveChanges();
                MessageBox.Show("Автомобиль успешно добавлен");
            }
            else
            {
                MessageBox.Show("Такой автомобиль уже существует");
            }               
        }

        public List<CarDTO> Get()
        {
            var cars = _context.Cars.Select(x => _mapper.Map<CarDTO>(x)).ToList();
            return cars;
        }

        public void Remove(CarDTO entity)
        {
            var car = _context.Cars.FirstOrDefault(x => x.Id == entity.Id);
            if (car != null)
            {
                _context.Cars.Remove(car);
                _context.SaveChanges();
                MessageBox.Show("Автомобиль успешно удалён");
            }
            else
            {
                MessageBox.Show("Автомобиль не найден");
            }                
        }

        public void UpDate(CarDTO entity)
        {
            var car = _context.Cars.FirstOrDefault(x => x.Id == entity.Id);
            if (car != null)
            {
                _mapper.Map(entity, car);
                _context.SaveChanges();
                MessageBox.Show("Данные успешно обновлены");
            }
            else
            {
                MessageBox.Show("Автомобиль не найден");
            }    
        }
    }
}
