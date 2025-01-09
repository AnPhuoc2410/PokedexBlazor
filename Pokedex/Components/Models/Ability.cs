namespace Pokedex.Components.Models
{
    public class Ability
    {
        public Ability2 ability { get; set; }
        public bool is_hidden { get; set; }
        public int slot { get; set; }
    }

    public class Ability2
    {
        public string name { get; set; }
        public string url { get; set; }
    }
}
