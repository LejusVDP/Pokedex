using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Raises the user's Special Attack, Special Defense, and Speed by one stage each.
	public class MoveQuiverDance : Move
	{
#nullable enable
		private static MoveQuiverDance? _instance = null;
#nullable restore
        public static MoveQuiverDance Instance => _instance ?? (_instance = new MoveQuiverDance());

		public MoveQuiverDance() : base(
			"Quiver-Dance",
			Bug.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}