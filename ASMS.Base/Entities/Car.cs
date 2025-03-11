using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMS.Base.Entities
{
    public class Car
    {
        public int Id { get; set; }  
        public string RegNumber { get; set; }  
        public string Brand { get; set; }  
        public string Model { get; set; }  
        public int Year { get; set; }  
        public string Vin { get; set; }
        public List<Client> Clients { get; set; } = new List<Client>();  
        public List<Order>  Orders{ get; set; } = new List<Order>();  

    }
}
