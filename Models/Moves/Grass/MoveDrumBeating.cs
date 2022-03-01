using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 100% chance to lower the target's Speed by one stage.
	public class MoveDrumBeating : Move
	{
		public MoveDrumBeating() : base(
			"Drum-Beating",
			Grass.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 80,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}