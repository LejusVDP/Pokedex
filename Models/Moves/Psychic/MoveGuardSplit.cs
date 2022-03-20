using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Averages Defense and Special Defense with the target.
	public class MoveGuardSplit : Move
	{
#nullable enable
		private static MoveGuardSplit? _instance = null;
#nullable restore
        public static MoveGuardSplit Instance => _instance ?? (_instance = new MoveGuardSplit());

		public MoveGuardSplit() : base(
			"Guard-Split",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}