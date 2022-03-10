using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Hits 2-5 times in one turn.
	public class MoveBarrage : Move
	{
		public MoveBarrage() : base(
			"Barrage",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 15,// PP & Pow
			85, 0 // Acc & Priority
		) {}
	}
}