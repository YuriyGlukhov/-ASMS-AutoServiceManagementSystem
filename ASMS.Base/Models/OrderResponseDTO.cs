using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMS.Base.Models
{
    public class OrderResponseDTO
    {
        public int OrderId { get; set; }
        public string? ClientName { get; set; }
        public string? ClientPhone { get; set; }
        public string? ServiceName { get; set; }
        public decimal? Price { get; set; }
    }
}
