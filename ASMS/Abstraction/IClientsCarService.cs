using ASMS.Base.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMS.Forms.Abstraction
{
    public interface IClientsCarService
    {
        void AddCarToClient(int clientId, int carId);
        void RemoveCarFromClient(int clientId, int carId);
        List<CarDTO> GetClientCars(int clientId);
    }
}
