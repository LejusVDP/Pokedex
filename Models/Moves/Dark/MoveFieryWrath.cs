using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveFieryWrath : Move
	{
		public MoveFieryWrath() : base(
			"Fiery-Wrath",
			Dark.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 90,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}