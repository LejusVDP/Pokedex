using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts more damage when the user has more HP remaining, with a maximum of 150 power.
	public class MoveEruption : Move
	{
#nullable enable
		private static MoveEruption? _instance = null;
#nullable restore
        public static MoveEruption Instance => _instance ?? (_instance = new MoveEruption());

		public MoveEruption() : base(
			"Eruption",
			Fire.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 150,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}