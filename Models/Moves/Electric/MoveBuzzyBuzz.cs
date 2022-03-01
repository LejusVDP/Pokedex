using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveBuzzyBuzz : Move
	{
		public MoveBuzzyBuzz() : base(
			"Buzzy-Buzz",
			Electric.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, 60,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}