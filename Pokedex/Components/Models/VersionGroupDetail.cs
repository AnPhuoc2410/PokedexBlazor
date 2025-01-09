namespace Pokedex.Components.Models
{
    public class VersionGroupDetail
    {
        public int level_learned_at { get; set; }
        public MoveLearnMethod move_learn_method { get; set; }
    }
    public class MoveLearnMethod
    {
        public string name { get; set; }
        public string url { get; set; }
    }
}
