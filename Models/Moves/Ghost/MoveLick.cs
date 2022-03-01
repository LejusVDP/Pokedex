using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to paralyze the target.
	public class MoveLick : Move
	{
		public MoveLick() : base(
			"Lick",
			Ghost.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			30, 30,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}