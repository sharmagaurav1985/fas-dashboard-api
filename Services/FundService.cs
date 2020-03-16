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
        public async Task<ServiceResponse<IEnumerable<Funds>>> AddNewFund(Funds newFund)
        {
            Dbcontext.Funds.Add(newFund);
            ServiceResponse<IEnumerable<Funds>> serviceResponse = new ServiceResponse<IEnumerable<Funds>>();
            serviceResponse.data = Dbcontext.Funds;
            return serviceResponse;
        }

        public async Task<ServiceResponse<IEnumerable<Funds>>> GetActiveFunds()
        {
            ServiceResponse<IEnumerable<Funds>> serviceResponse = new ServiceResponse<IEnumerable<Funds>>();
            serviceResponse.data = Dbcontext.Funds.Where(x => x.IsActive == 1);
            return serviceResponse;
        }

        public async Task<ServiceResponse<IEnumerable<Funds>>> GetAllFunds()
        {
            ServiceResponse<IEnumerable<Funds>> serviceResponse = new ServiceResponse<IEnumerable<Funds>>();
            serviceResponse.data = Dbcontext.Funds;
            return serviceResponse;
        }

        public async Task<ServiceResponse<IEnumerable<Funds>>> GetInActiveFunds()
        {
            ServiceResponse<IEnumerable<Funds>> serviceResponse = new ServiceResponse<IEnumerable<Funds>>();
            serviceResponse.data = Dbcontext.Funds.Where(x => x.IsActive == 0);
            return serviceResponse;
        }

        public async Task<ServiceResponse<Funds>> GetSingleFund(int id)
        {
            ServiceResponse<Funds> serviceResponse = new ServiceResponse<Funds>();
            serviceResponse.data = Dbcontext.Funds.FirstOrDefault(x => x.FundId == id);
            return serviceResponse;
        }
    }
}