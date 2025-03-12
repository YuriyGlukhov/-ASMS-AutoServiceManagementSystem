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
        public int ClientId { get; set; }
        public int CarId { get; set; }
    }
}
