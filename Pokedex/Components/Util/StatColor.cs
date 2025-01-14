namespace Pokedex.Components.Util
{
    public static class StatColor
    {
        public static string GetColor(string stat)
        {
            switch (stat)
            {
                case "hp":
                    return "#FF5959";
                case "attack":
                    return "#F5AC78";
                case "defense":
                    return "#FAE078";
                case "special-attack":
                    return "#9DB7F5";
                case "special-defense":
                    return "#A7DB8D";
                case "speed":
                    return "#FA92B2";
                default:
                    return "#000000";
            }
        }
    }
}
