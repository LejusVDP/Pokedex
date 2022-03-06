using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//If the target is asleep, has double power and wakes it up.
	public class MoveWakeUpSlap : Move
	{
		public MoveWakeUpSlap() : base(
			"Wake-Up-Slap",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 70,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}