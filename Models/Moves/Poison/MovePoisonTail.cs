using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Has an increased chance for a critical hit and a 10% chance to poison the target.
	public class MovePoisonTail : Move
	{
		public MovePoisonTail() : base(
			"Poison-Tail",
			Poison.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			25, 50,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}