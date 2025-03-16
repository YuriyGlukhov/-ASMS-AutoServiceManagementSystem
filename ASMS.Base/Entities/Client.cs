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
        public string? Phone { get; set; }
        public DateTime BirthDay { get; set; }
        public virtual List<Car> Cars { get; set; } = new List<Car>();
        public virtual List<Order> Orders { get; set; } = new List<Order>();
    }
}
