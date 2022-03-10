using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Has an increased chance for a critical hit.
	public class MoveStoneEdge : Move
	{
		public MoveStoneEdge() : base(
			"Stone-Edge",
			Rock.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 100,// PP & Pow
			80, 0 // Acc & Priority
		) {}
	}
}