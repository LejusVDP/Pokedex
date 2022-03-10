using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the target's accuracy by one stage.
	public class MoveKinesis : Move
	{
		public MoveKinesis() : base(
			"Kinesis",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			80, 0 // Acc & Priority
		) {}
	}
}