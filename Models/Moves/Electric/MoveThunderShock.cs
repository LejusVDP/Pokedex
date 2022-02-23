using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to paralyze the target.
	public class MoveThunderShock : Move
	{
		public MoveThunderShock() : base(
			"Thunder-Shock",
			Electric.Instance, // Move Type
			MoveCategory.Special, // Move Category
			30, 40,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}