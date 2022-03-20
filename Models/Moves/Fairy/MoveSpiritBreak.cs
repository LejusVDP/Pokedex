using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 100% chance to lower the target's Special Attack by one stage.
	public class MoveSpiritBreak : Move
	{
#nullable enable
		private static MoveSpiritBreak? _instance = null;
#nullable restore
        public static MoveSpiritBreak Instance => _instance ?? (_instance = new MoveSpiritBreak());

		public MoveSpiritBreak() : base(
			"Spirit-Break",
			Fairy.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 75,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}