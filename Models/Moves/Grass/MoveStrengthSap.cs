using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Heals the user by the target's current Attack stat and lowers the target's Attack by one stage.
	public class MoveStrengthSap : Move
	{
		public MoveStrengthSap() : base(
			"Strength-Sap",
			Grass.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}