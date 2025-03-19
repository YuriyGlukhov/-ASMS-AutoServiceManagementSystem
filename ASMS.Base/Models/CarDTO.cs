using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMS.Base.Models
{
   public class CarDTO
    {
        public int Id { get; set; }
        public string RegNumber { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Vin {  get; set; }
        public int Year { get; set; }
        public string DisplayText
        {
            get
            {
                return $"{Brand} {Model} ({RegNumber})";
            }
        }
    }
}
