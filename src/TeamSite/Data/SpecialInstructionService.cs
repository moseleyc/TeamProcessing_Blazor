using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamSite.Data
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
