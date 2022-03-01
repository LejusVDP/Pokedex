using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to lower the target's Speed by one stage.
	public class MoveBubbleBeam : Move
	{
		public MoveBubbleBeam() : base(
			"Bubble-Beam",
			Water.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, 65,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}