namespace Pokedex.Components.Models
{
    public class Type
    {
        public int slot { get; set; }
        public Type2 type { get; set; }
    }

    public class Type2
    {
        public string name { get; set; }
        public string url { get; set; }
    }
}
