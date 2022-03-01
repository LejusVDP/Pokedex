using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to paralyze the target.
	public class MoveThunderbolt : Move
	{
		public MoveThunderbolt() : base(
			"Thunderbolt",
			Electric.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 90,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}