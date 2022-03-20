using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Hits 2-5 times in one turn.
	public class MoveArmThrust : Move
	{
#nullable enable
		private static MoveArmThrust? _instance = null;
#nullable restore
        public static MoveArmThrust Instance => _instance ?? (_instance = new MoveArmThrust());

		public MoveArmThrust() : base(
			"Arm-Thrust",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 15,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}