using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Power is higher when the user weighs more than the target, up to a maximum of 120.
	public class MoveHeavySlam : Move
	{
		public MoveHeavySlam() : base(
			"Heavy-Slam",
			Steel.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, null,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}