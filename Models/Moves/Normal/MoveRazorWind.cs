using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Requires a turn to charge before attacking.
	public class MoveRazorWind : Move
	{
		public MoveRazorWind() : base(
			"Razor-Wind",
			Normal.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 80,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}