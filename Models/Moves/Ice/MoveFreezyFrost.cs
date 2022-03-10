using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveFreezyFrost : Move
	{
		public MoveFreezyFrost() : base(
			"Freezy-Frost",
			Ice.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 100,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}