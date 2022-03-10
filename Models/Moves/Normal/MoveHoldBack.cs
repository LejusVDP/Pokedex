using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Cannot lower the target's HP below 1.
	public class MoveHoldBack : Move
	{
		public MoveHoldBack() : base(
			"Hold-Back",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			40, 40,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}