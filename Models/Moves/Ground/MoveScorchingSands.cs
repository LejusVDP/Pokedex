using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveScorchingSands : Move
	{
		public MoveScorchingSands() : base(
			"Scorching-Sands",
			Ground.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 70,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}