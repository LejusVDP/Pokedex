using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MovePowerGem : Move
	{
#nullable enable
		private static MovePowerGem? _instance = null;
#nullable restore
        public static MovePowerGem Instance => _instance ?? (_instance = new MovePowerGem());

		public MovePowerGem() : base(
			"Power-Gem",
			Rock.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, 80,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}