using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the user's Defense and Special Defense by one stage after inflicting damage.
	public class MoveCloseCombat : Move
	{
		public MoveCloseCombat() : base(
			"Close-Combat",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 120,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}