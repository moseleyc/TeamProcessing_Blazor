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
using ManagedAccountsWeb.Data.Migrations;

namespace ManagedAccountsWeb.Services
{
    public class SpecialInstructionService : ISpecialInstructionService
    {
        private readonly ILogger _logger;
        private readonly TeamSiteDbContext _dbContext;
        private List<SpecialInstruction> SpecialInstructions { get; set; }

        public SpecialInstructionService(ILogger<SpecialInstructionService> logger, TeamSiteDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public async Task<List<SpecialInstruction>> GetAllSpecialInstructionsAsync()
        {
            return _dbContext.SpecialInstructions.ToList();
        }

        public bool AddSpecialInstruction(SpecialInstruction specialInstruction)
        {
            try
            {
                _dbContext.Add(specialInstruction);
                return _dbContext.SaveChanges() != 0;
            }
            catch
            {

            }
            return false;
        }

        public bool EditSpecialInstruction(SpecialInstruction specialInstruction)
        {
            try
            {
                _dbContext.Entry(specialInstruction).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                return _dbContext.SaveChanges() != 0;
            }
            catch
            {

            }
            return false;
        }
    }
}
