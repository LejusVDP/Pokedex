using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Heals the target for half its max HP.
	public class MoveHealPulse : Move
	{
#nullable enable
		private static MoveHealPulse? _instance = null;
#nullable restore
        public static MoveHealPulse Instance => _instance ?? (_instance = new MoveHealPulse());

		public MoveHealPulse() : base(
			"Heal-Pulse",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}