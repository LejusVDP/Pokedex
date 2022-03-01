using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to make the target flinch.
	public class MoveIronHead : Move
	{
		public MoveIronHead() : base(
			"Iron-Head",
			Steel.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 80,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}