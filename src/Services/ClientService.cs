using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fas_dashboard_api.Models;

namespace fas_dashboard_api.Services
{
    public class ClientService : IClientService
    {
        public TESTFASContext Dbcontext { get; set; }
        public ClientService(TESTFASContext dbcontext)
        {
            this.Dbcontext = dbcontext;

        }


        public async Task<ServiceResponse<IEnumerable<Clients>>> GetAllClients()
        {
            ServiceResponse<IEnumerable<Clients>> serviceResponse = new ServiceResponse<IEnumerable<Clients>>();
            serviceResponse.data = Dbcontext.Clients;
            return serviceResponse;
        }

    }
}