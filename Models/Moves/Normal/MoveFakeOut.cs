using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Can only be used as the first move after the user enters battle.  Causes the target to flinch.
	public class MoveFakeOut : Move
	{
		public MoveFakeOut() : base(
			"Fake-Out",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 40,// PP & Pow
			100, 3 // Acc & Priority
		) {}
	}
}