using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Raises the user's Speed by two stages.
	public class MoveRockPolish : Move
	{
		public MoveRockPolish() : base(
			"Rock-Polish",
			Rock.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}