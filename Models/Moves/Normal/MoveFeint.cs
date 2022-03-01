using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Hits through Protect and Detect.
	public class MoveFeint : Move
	{
		public MoveFeint() : base(
			"Feint",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 30,// PP & Pow
			1.0, 2 // Acc & Priority
		) {}
	}
}