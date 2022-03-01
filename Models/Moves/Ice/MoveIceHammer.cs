using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Lowers user's Speed by one stage.
	public class MoveIceHammer : Move
	{
		public MoveIceHammer() : base(
			"Ice-Hammer",
			Ice.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 100,// PP & Pow
			0.9, 0 // Acc & Priority
		) {}
	}
}