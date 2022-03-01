using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Power doubles every turn this move is used in succession after the first, resetting after five turns.
	public class MoveIceBall : Move
	{
		public MoveIceBall() : base(
			"Ice-Ball",
			Ice.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 30,// PP & Pow
			0.9, 0 // Acc & Priority
		) {}
	}
}