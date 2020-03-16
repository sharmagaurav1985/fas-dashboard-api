using System.Collections.Generic;
using System.Threading.Tasks;
using fas_dashboard_api.Models;
using Microsoft.AspNetCore.Mvc;

namespace fas_dashboard_api.Services
{
    public interface IFundService
    {
        Task<ServiceResponse<IEnumerable<Funds>>> GetAllFunds();
        Task<ServiceResponse<Funds>> GetSingleFund(int id);
        Task<ServiceResponse<IEnumerable<Funds>>> GetActiveFunds();
        Task<ServiceResponse<IEnumerable<Funds>>> GetInActiveFunds();
        Task<ServiceResponse<IEnumerable<Funds>>> AddNewFund(Funds newFund);
    }
}