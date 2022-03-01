using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveHyperVoice : Move
	{
		public MoveHyperVoice() : base(
			"Hyper-Voice",
			Normal.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 90,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}