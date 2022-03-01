using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Puts the target to sleep.
	public class MoveSleepPowder : Move
	{
		public MoveSleepPowder() : base(
			"Sleep-Powder",
			Grass.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			0.75, 0 // Acc & Priority
		) {}
	}
}