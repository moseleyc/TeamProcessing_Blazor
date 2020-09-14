using ManagedAccountClasses.TeamSite;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ManagedAccountsWeb.Services
{
    public class SpecialInstructionService : ISpecialInstructionService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger _logger;

        public SpecialInstructionService(IHttpClientFactory httpClientFactory, ILogger<SpecialInstructionService> logger)
        {
            _httpClient = httpClientFactory.CreateClient();
            _logger = logger;
        }


        public async Task<List<SpecialInstruction>> GetSpecialInstructionAsync()
        {
            var response = await _httpClient.GetAsync("https://localhost:5003/managedaccounts/specialInstructions");
            _logger.LogInformation($"IsSuccessful: {response.IsSuccessStatusCode}; Results: {response?.Content?.ReadAsStringAsync().Result}");
            var specialInstructions = JsonConvert.DeserializeObject<List<SpecialInstruction>>(await response.Content.ReadAsStringAsync());

            return specialInstructions;
        }

        public async Task<bool> AddSpecialInstructionAsync(SpecialInstruction specialInstruction)
        {
            var payload = JsonConvert.SerializeObject(specialInstruction);
            HttpContent content = new StringContent(payload, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("https://localhost:5003/managedaccounts/specialInstructions", content);
            return response.IsSuccessStatusCode;
        }
    }
}
