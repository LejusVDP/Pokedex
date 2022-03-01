using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to lower the target's Special Defense by one stage.
	public class MoveAcid : Move
	{
		public MoveAcid() : base(
			"Acid",
			Poison.Instance, // Move Type
			MoveCategory.Special, // Move Category
			30, 40,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}