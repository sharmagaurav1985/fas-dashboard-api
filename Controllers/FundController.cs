using System.Collections.Generic;
using System.Threading.Tasks;
using fas_dashboard_api.Models;
using fas_dashboard_api.Services;
using Microsoft.AspNetCore.Mvc;

namespace fas_dashboard_api.Controllers
{
    [ApiController]
    [Route("api/funds")]
    public class FundController : ControllerBase
    {
        private IFundService FundService { get; set; }
        public TESTFASContext DbContext { get; set; }
        public FundController(IFundService fundService, TESTFASContext dbContext)
        {
            this.DbContext = dbContext;
            this.FundService = fundService;
        }

        [HttpGet("GetAllFunds")]
        public async Task<IActionResult> GetAllFunds()
        {
            return Ok(await FundService.GetAllFunds());
        }
    }
}