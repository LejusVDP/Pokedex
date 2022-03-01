using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Ends wild battles.  Forces trainers to switch Pokémon.
	public class MoveDragonTail : Move
	{
		public MoveDragonTail() : base(
			"Dragon-Tail",
			Dragon.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 60,// PP & Pow
			0.9, -6 // Acc & Priority
		) {}
	}
}