using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to make the target flinch.
	public class MoveHyperFang : Move
	{
		public MoveHyperFang() : base(
			"Hyper-Fang",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 80,// PP & Pow
			0.9, 0 // Acc & Priority
		) {}
	}
}