using Pokedex.Components.Models;
using System.Text.Json;

namespace Pokedex.Components.Util
{
    public class PokeClient(HttpClient httpClient)
    {
        public HttpClient HttpClient { get; } = httpClient;
        
        public async Task<Pokemon> GetPokemon(string name)
        {
            try
            {
                using var response = await httpClient.GetAsync($"https://pokeapi.co/api/v2/pokemon/{name}");
                if (!response.IsSuccessStatusCode) return null;

                await using var stream = await response.Content.ReadAsStreamAsync();
                return await JsonSerializer.DeserializeAsync<Pokemon>(stream);
            }
            catch (Exception ex)
            {
                // Log or handle exception (optional)
                Console.WriteLine($"Error fetching Pokemon: {ex.Message}");
                return null;
            }
        }
    }
}