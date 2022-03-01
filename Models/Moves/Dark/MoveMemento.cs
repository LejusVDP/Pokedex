using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Lowers the target's Attack and Special Attack by two stages.  User faints.
	public class MoveMemento : Move
	{
		public MoveMemento() : base(
			"Memento",
			Dark.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}