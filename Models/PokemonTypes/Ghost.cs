namespace Pokedex.Models.PokeTypes
{
    public class Ghost : PokeType
    {
#nullable enable
        private static Ghost? _instance = null;
#nullable disable
        public static Ghost Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Ghost();
                }
                return _instance;
            }
        }
        private Ghost() : base("Ghost", "Bleuet")
        {
        }
    }
}