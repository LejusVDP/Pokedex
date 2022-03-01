using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 100% chance to lower the target's Speed by one stage.
	public class MoveBulldoze : Move
	{
		public MoveBulldoze() : base(
			"Bulldoze",
			Ground.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 60,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}