using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Power increases by 100% for each consecutive use by any friendly Pokémon, to a maximum of 200.
	public class MoveEchoedVoice : Move
	{
		public MoveEchoedVoice() : base(
			"Echoed-Voice",
			Normal.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 40,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}