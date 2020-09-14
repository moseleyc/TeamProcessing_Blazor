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
            SetSpecialInstructionsInitial();
        }

        [HttpGet]
        [Route("specialInstructions")]
        public async Task<IActionResult> SpecialInstructions_Get()
        {
            IEnumerable<SpecialInstruction> returnObject = await Task.FromResult(SpecialInstructions);

            return Ok(returnObject);
        }

        [HttpPost]
        [Route("specialInstructions")]
        public async Task<IActionResult> SpecialInstructions_Add(SpecialInstruction specialInstruction)
        {
            SpecialInstructions.Add(specialInstruction);

            return Ok();
        }

        private static List<SpecialInstruction> SpecialInstructions = new List<SpecialInstruction>();

        private void SetSpecialInstructionsInitial()
        {
            SpecialInstructions.Add(new SpecialInstruction
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
