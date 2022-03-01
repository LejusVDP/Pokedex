using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveAquaTail : Move
	{
		public MoveAquaTail() : base(
			"Aqua-Tail",
			Water.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 90,// PP & Pow
			0.9, 0 // Acc & Priority
		) {}
	}
}