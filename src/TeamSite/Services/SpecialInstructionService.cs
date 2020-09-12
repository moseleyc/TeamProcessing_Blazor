using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TeamSite.Classes.TeamSite;

namespace TeamSite.Services
{
    public class SpecialInstructionService
    {         
        public Task<List<SpecialInstruction>> GetSpecialInstructionAsync()
        {
            return Task.FromResult(new List<SpecialInstruction>
            {
                new SpecialInstruction
                {
                    Id = 1,
                    AccountNumber = "T00002A1",
                    Notes = "Nothing Special Here",
                    EnteredBy = "tqa",
                    EnteredDate = new DateTime(2020, 07, 05)
                }
            });
        }
    }
}
