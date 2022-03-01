using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Prevents the target from using the same move twice in a row.
	public class MoveTorment : Move
	{
		public MoveTorment() : base(
			"Torment",
			Dark.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}