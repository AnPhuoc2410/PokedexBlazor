using Newtonsoft.Json;
using Pokedex.Components.Pages;

namespace Pokedex.Components.Models
{
    public class Sprites
    {
        public string back_default { get; set; }
        public object back_female { get; set; }
        public string back_shiny { get; set; }
        public object back_shiny_female { get; set; }
        public string front_default { get; set; }
        public object front_female { get; set; }
        public string front_shiny { get; set; }
        public object front_shiny_female { get; set; }
        public Other other { get; set; }

    }
    public class OfficialArtwork
    {
        public string front_default { get; set; }
        public string front_shiny { get; set; }
    }
    public class Other
    {
        public DreamWorld dream_world { get; set; }
        public Home home { get; set; }

        [JsonProperty("official-artwork")]
        public OfficialArtwork officialartwork { get; set; }
        public Showdown showdown { get; set; }
    }
    public class DreamWorld
    {
        public string front_default { get; set; }
        public object front_female { get; set; }
    }
    public class Home
    {
        public string front_default { get; set; }
        public object front_female { get; set; }
        public string front_shiny { get; set; }
        public object front_shiny_female { get; set; }
    }
    public class Showdown
    {
        public string back_default { get; set; }
        public object back_female { get; set; }
        public string back_shiny { get; set; }
        public object back_shiny_female { get; set; }
        public string front_default { get; set; }
        public object front_female { get; set; }
        public string front_shiny { get; set; }
        public object front_shiny_female { get; set; }
    }
}
