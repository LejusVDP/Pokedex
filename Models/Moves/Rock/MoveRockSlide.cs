using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to make the target flinch.
	public class MoveRockSlide : Move
	{
		public MoveRockSlide() : base(
			"Rock-Slide",
			Rock.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 75,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}