using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 20% chance to lower the target's Defense by one stage.
	public class MoveCrunch : Move
	{
		public MoveCrunch() : base(
			"Crunch",
			Dark.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 80,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}