using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 100% chance to paralyze the target.
	public class MoveNuzzle : Move
	{
		public MoveNuzzle() : base(
			"Nuzzle",
			Electric.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 20,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}