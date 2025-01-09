using Pokedex.Components.Models;
using System.Text.Json;

namespace Pokedex.Components.Util
{
    public class PokeClient
    {
        public HttpClient httpClient { get; set; }
        public PokeClient(HttpClient httpClient)
        {
            this.httpClient = httpClient;
             
        }
        public async Task<Pokemon> GetPokemon(string name)
        {
            var response = await httpClient.GetAsync($"https://pokeapi.co/api/v2/pokemon/{name}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<Pokemon>(content);
            }
            return null;
        }
    }
}
