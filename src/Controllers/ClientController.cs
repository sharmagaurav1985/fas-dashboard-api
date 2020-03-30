using System.Collections.Generic;
using System.Threading.Tasks;
using fas_dashboard_api.Models;
using fas_dashboard_api.Services;
using Microsoft.AspNetCore.Mvc;

namespace fas_dashboard_api.Controllers
{
    [ApiController]
    [Route("api/clients")]
    public class ClientController : ControllerBase
    {
        private IClientService ClientService { get; set; }
        public ClientController(IClientService clientService)
        {
            this.ClientService = clientService;
        }

        [HttpGet("GetAllClients")]
        public async Task<IActionResult> GetAllClients()
        {
            return Ok(await ClientService.GetAllClients());
        }
    }
}