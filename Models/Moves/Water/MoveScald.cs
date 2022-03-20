using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to burn the target.
	public class MoveScald : Move
	{
#nullable enable
		private static MoveScald? _instance = null;
#nullable restore
        public static MoveScald Instance => _instance ?? (_instance = new MoveScald());

		public MoveScald() : base(
			"Scald",
			Water.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 80,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}