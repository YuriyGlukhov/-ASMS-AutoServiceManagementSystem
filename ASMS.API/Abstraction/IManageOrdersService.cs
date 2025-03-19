using ASMS.Base.Models;

namespace ASMS.API.Abstraction
{
    public interface IManageOrdersService
    {
        public List<ServiceDTO> GetServicesByCarBrand (string carBrand);
        public OrderResponseDTO CreateNewOrder(string clientName, string clientPhone,string Vin, int serviceId);
    }
}
