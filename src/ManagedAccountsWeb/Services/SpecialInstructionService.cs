using ManagedAccountClasses.TeamSite;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ManagedAccountsWeb.Services
{
    public class SpecialInstructionService : ISpecialInstructionService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger _logger;

        public SpecialInstructionService(HttpClient httpClient, ILogger<SpecialInstructionService> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }


        public async Task<List<SpecialInstruction>> GetSpecialInstructionAsync()
        {
            var response = await _httpClient.GetAsync("managedaccounts/specialInstructions");
            _logger.LogInformation($"IsSuccessful: {response.IsSuccessStatusCode}; Results: {response?.Content?.ReadAsStringAsync().Result}");
            var specialInstructions = JsonConvert.DeserializeObject<List<SpecialInstruction>>(await response.Content.ReadAsStringAsync());

            return specialInstructions;
        }
    }
}
