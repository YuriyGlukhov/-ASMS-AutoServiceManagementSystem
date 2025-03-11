using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMS.Base.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
        public List<Car> Cars { get; set; } = new List<Car>();
        public List<Order> Orders { get; set; } = new List<Order>();
    }
}
