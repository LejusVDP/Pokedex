using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveThunderCage : Move
	{
		public MoveThunderCage() : base(
			"Thunder-Cage",
			Electric.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 80,// PP & Pow
			0.9, 0 // Acc & Priority
		) {}
	}
}