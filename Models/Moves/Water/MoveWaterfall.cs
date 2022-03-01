using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 20% chance to make the target flinch.
	public class MoveWaterfall : Move
	{
		public MoveWaterfall() : base(
			"Waterfall",
			Water.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 80,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}