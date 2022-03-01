using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//If target has a berry, inflicts double damage and uses the berry.
	public class MoveBugBite : Move
	{
		public MoveBugBite() : base(
			"Bug-Bite",
			Bug.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 60,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}