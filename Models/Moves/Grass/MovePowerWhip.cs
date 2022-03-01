using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MovePowerWhip : Move
	{
		public MovePowerWhip() : base(
			"Power-Whip",
			Grass.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 120,// PP & Pow
			0.85, 0 // Acc & Priority
		) {}
	}
}