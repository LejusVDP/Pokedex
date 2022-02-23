using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to paralyze the target.
	public class MoveThunder : Move
	{
		public MoveThunder() : base(
			"Thunder",
			Electric.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 110,// PP & Pow
			70, 0 // Acc & Priority
			
		) {}
	}
}