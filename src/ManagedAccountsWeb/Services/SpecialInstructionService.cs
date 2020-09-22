using ManagedAccountClasses.TeamSite;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ManagedAccountsWeb.Services
{
    public class SpecialInstructionService : ISpecialInstructionService
    {
        private readonly ILogger _logger;
        private List<SpecialInstruction> SpecialInstructions { get; set; }

        public SpecialInstructionService(ILogger<SpecialInstructionService> logger)
        {
            _logger = logger;

            SpecialInstructions = GetSpecialInstructionsInitialSetup();
        }


        public async Task<List<SpecialInstruction>> GetSpecialInstructionAsync()
        {
            return SpecialInstructions;
        }

        public async Task<bool> AddSpecialInstructionAsync(SpecialInstruction specialInstruction)
        {
            SpecialInstructions.Add(specialInstruction);

            if(SpecialInstructions.Any(x => x.Equals(specialInstruction)))
            {
                return true;
            }

            return false;
        }

        private List<SpecialInstruction> GetSpecialInstructionsInitialSetup()
        {
            return new List<SpecialInstruction>
            {
                new SpecialInstruction
                {
                    AccountNumber = "T00002A1",
                    Notes = "Nothing to see here",
                    EnteredBy = "hjunata@gmail.com",
                    EnteredDate = DateTime.Now
                }
            };
        }
    }
}
