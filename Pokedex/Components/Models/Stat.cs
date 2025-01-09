namespace Pokedex.Components.Models
{
    public class Stat
    {
        public int base_stat { get; set; }
        public int effort { get; set; }
        public Stat2 stat { get; set; }
    }

    public class Stat2
    {
        public string name { get; set; }
        public string url { get; set; }
    }
}
