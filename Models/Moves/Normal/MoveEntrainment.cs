using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Copies the user's ability onto the target.
	public class MoveEntrainment : Move
	{
		public MoveEntrainment() : base(
			"Entrainment",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}