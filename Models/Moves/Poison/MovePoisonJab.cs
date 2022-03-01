using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to poison the target.
	public class MovePoisonJab : Move
	{
		public MovePoisonJab() : base(
			"Poison-Jab",
			Poison.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 80,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}