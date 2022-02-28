using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Drains 75% of the damage inflicted to heal the user.
	public class MoveDrainingKiss : Move
	{
		public MoveDrainingKiss() : base(
			"Draining-Kiss",
			Fairy.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 50,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}