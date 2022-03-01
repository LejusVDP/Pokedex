using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MovePowerGem : Move
	{
		public MovePowerGem() : base(
			"Power-Gem",
			Rock.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, 80,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}