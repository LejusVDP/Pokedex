using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Raises the user's Attack by one stage after inflicting damage.
	public class MovePowerUpPunch : Move
	{
		public MovePowerUpPunch() : base(
			"Power-Up-Punch",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 40,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}