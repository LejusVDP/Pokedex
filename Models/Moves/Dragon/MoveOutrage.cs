using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Hits every turn for 2-3 turns, then confuses the user.
	public class MoveOutrage : Move
	{
		public MoveOutrage() : base(
			"Outrage",
			Dragon.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 120,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}