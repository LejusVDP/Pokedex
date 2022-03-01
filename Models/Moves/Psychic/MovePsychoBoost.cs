using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Lowers the user's Special Attack by two stages after inflicting damage.
	public class MovePsychoBoost : Move
	{
		public MovePsychoBoost() : base(
			"Psycho-Boost",
			Psychic.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 140,// PP & Pow
			0.9, 0 // Acc & Priority
		) {}
	}
}