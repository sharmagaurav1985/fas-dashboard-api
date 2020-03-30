using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fas_dashboard_api.Models;

namespace fas_dashboard_api.Services
{
    public class FundService : IFundService
    {
        public TESTFASContext Dbcontext { get; set; }
        public FundService(TESTFASContext dbcontext)
        {
            this.Dbcontext = dbcontext;

        }

        public async Task<ServiceResponse<IEnumerable<Funds>>> GetAllFunds()
        {
            ServiceResponse<IEnumerable<Funds>> serviceResponse = new ServiceResponse<IEnumerable<Funds>>();
            serviceResponse.data = Dbcontext.Funds;
            return serviceResponse;
        }

        public async Task<ServiceResponse<IEnumerable<Funds>>> GetFund(int clientId)
        {
            ServiceResponse<IEnumerable<Funds>> serviceResponse = new ServiceResponse<IEnumerable<Funds>>();
            serviceResponse.data = Dbcontext.Funds.Where(x => x.ClientId == clientId);
            return serviceResponse;
        }

    }
}