using ManagedAccountClasses.TeamSite;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ManagedAccountsWeb.Services
{
    public interface ISpecialInstructionService
    {
        public Task<List<SpecialInstruction>> GetSpecialInstructionAsync();
    }
}