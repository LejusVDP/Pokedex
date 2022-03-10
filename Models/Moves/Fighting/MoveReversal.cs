using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts more damage when the user has less HP remaining, with a maximum of 200 power.
	public class MoveReversal : Move
	{
		public MoveReversal() : base(
			"Reversal",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}