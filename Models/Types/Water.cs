﻿namespace Pokedex.Models.Types
{
    internal class Water : PokemonType
    {
        private static Water? _instance = null;
        public static Water Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Water();
                }
                return _instance;
            }
        }
        private Water() : base ("Water", "Blue")
        {

        }
    }
}