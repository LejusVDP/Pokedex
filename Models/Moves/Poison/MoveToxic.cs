using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Badly poisons the target, inflicting more damage every turn.
	public class MoveToxic : Move
	{
		public MoveToxic() : base(
			"Toxic",
			Poison.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			0.9, 0 // Acc & Priority
		) {}
	}
}