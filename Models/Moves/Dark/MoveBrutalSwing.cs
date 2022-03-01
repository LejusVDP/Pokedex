using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveBrutalSwing : Move
	{
		public MoveBrutalSwing() : base(
			"Brutal-Swing",
			Dark.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 60,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}