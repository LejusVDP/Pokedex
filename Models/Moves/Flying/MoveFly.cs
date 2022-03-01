using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//User flies high into the air, dodging all attacks, and hits next turn.
	public class MoveFly : Move
	{
		public MoveFly() : base(
			"Fly",
			Flying.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 90,// PP & Pow
			0.95, 0 // Acc & Priority
		) {}
	}
}