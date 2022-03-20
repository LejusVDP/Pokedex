using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 100% chance to lower the target's Speed by one stage.
	public class MoveBulldoze : Move
	{
#nullable enable
		private static MoveBulldoze? _instance = null;
#nullable restore
        public static MoveBulldoze Instance => _instance ?? (_instance = new MoveBulldoze());

		public MoveBulldoze() : base(
			"Bulldoze",
			Ground.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 60,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}