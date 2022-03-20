using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Ally's next move inflicts half more damage.
	public class MoveHelpingHand : Move
	{
#nullable enable
		private static MoveHelpingHand? _instance = null;
#nullable restore
        public static MoveHelpingHand Instance => _instance ?? (_instance = new MoveHelpingHand());

		public MoveHelpingHand() : base(
			"Helping-Hand",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 5 // Acc & Priority
		) {}
	}
}