using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveMaxRockfall : Move
	{
		public MoveMaxRockfall() : base(
			"Max-Rockfall",
			Rock.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 10,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}