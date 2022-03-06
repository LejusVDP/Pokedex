using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 20% chance to confuse the target.
	public class MoveWaterPulse : Move
	{
		public MoveWaterPulse() : base(
			"Water-Pulse",
			Water.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, 60,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}