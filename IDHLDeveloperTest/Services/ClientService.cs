using IDHLDeveloperTest.Models;
using System.Text.Json;

namespace IDHLDeveloperTest.Services
{
    public class ClientService : IClientService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ClientService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<CharacterList> GetCharacters(int pageNumber)
        {
            return await GetDisneyResource<CharacterList>($"characters?page={pageNumber}");
        }

        public async Task<Character> GetCharacter(int id)
        {
            return await GetDisneyResource<Character>($"characters/{id}");
        }

        private async Task<T> GetDisneyResource<T>(string path)
        {
            var client = _httpClientFactory.CreateClient();
            var stream = await client.GetStreamAsync($"https://api.disneyapi.dev/{path}");
            return await JsonSerializer.DeserializeAsync<T>(stream);
        }
    }
}
