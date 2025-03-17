using ASMS.Base.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMS.Base.Models
{
   public class OrderDTO
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public OrderStatus Status { get; set; }
        public int ClientId { get; set; }
        public string? ClientName { get; set; }
        public int CarId { get; set; }
        public string? CarInfo { get; set; }
        public string? ServicesInfo { get; set; }

        public List<ServiceDTO> Services { get; set; } = new List<ServiceDTO>();
    }
}
