using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMS.Base.Entities
{
    public class OrderServices
    {
        public int? OrderId { get; set; }  
        public virtual Order? Order { get; set; }

        public int? ServiceId { get; set; }  
        public virtual Service? Service { get; set; }

       
    }
}
