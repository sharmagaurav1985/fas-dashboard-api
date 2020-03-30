using System.Collections.Generic;
using System.Threading.Tasks;
using fas_dashboard_api.Models;

namespace fas_dashboard_api.Services
{
    public interface IClientService
    {
        Task<ServiceResponse<IEnumerable<Clients>>> GetAllClients();
    }
}