using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Drains half the damage inflicted to heal the user.
	public class MoveDrainPunch : Move
	{
		public MoveDrainPunch() : base(
			"Drain-Punch",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 75,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}