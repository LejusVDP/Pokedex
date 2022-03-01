using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has an increased chance for a critical hit.
	public class MoveAttackOrder : Move
	{
		public MoveAttackOrder() : base(
			"Attack-Order",
			Bug.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 90,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}