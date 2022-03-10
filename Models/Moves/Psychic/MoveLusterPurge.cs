using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Has a 50% chance to lower the target's Special Defense by one stage.
	public class MoveLusterPurge : Move
	{
		public MoveLusterPurge() : base(
			"Luster-Purge",
			Psychic.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 70,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}