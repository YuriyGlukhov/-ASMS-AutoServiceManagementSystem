using ASMS.Base.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMS.Base.Entities
{
    public class Order
    {
        public int Id { get; set; } 
        public DateTime OrderDate { get; set; } = DateTime.Now; 
        public OrderStatus Status { get; set; } 
        public string? Description { get; set; }
        public int? ClientId { get; set; }
        public virtual Client? Client { get; set; }

        public int? CarId { get; set; }
        public virtual Car? Car { get; set; }

        public virtual List<Service> Services { get; set; } = new List<Service>();
    }
}
