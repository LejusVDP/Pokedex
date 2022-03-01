using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//If the user is holding a appropriate plate or drive, the damage inflicted will match it.
	public class MoveJudgment : Move
	{
		public MoveJudgment() : base(
			"Judgment",
			Normal.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 100,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}