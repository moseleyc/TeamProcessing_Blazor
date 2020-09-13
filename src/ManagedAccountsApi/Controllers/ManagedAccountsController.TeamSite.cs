using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManagedAccountClasses.TeamSite;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ManagedAccountsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ManagedAccountsController : Controller
    {
        private readonly ILogger<ManagedAccountsController> _logger;

        public ManagedAccountsController(ILogger<ManagedAccountsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("specialInstructions")]
        public IEnumerable<SpecialInstruction> GetSpecialInstructions()
        {
            return Enumerable.Range(1, 1).Select(index => new SpecialInstruction
            {
                Id = 1,
                AccountNumber = "T00002A1",
                Notes = "Nothing Special Here",
                EnteredBy = "hjunata@aviso.ca",
                EnteredDate = DateTime.Now
            });
        }
    }
}
