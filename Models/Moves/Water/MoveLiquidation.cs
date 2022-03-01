using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 20% chance to lower the target's Defense by one stage.
	public class MoveLiquidation : Move
	{
		public MoveLiquidation() : base(
			"Liquidation",
			Water.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 85,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}