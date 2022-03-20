using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class Move10000000VoltThunderbolt : Move
	{
#nullable enable
		private static Move10000000VoltThunderbolt? _instance = null;
#nullable restore
        public static Move10000000VoltThunderbolt Instance => _instance ?? (_instance = new Move10000000VoltThunderbolt());

		public Move10000000VoltThunderbolt() : base(
			"10-000-000-Volt-Thunderbolt",
			Electric.Instance, // Move Type
			MoveCategory.Special, // Move Category
			1, 195,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}