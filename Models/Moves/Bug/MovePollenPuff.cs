using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Damages opponents, but heals allies for 50% of their max HP.
	public class MovePollenPuff : Move
	{
#nullable enable
		private static MovePollenPuff? _instance = null;
#nullable restore
        public static MovePollenPuff Instance => _instance ?? (_instance = new MovePollenPuff());

		public MovePollenPuff() : base(
			"Pollen-Puff",
			Bug.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 90,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}