using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Drains half the damage inflicted to heal the user.
	public class MoveGigaDrain : Move
	{
#nullable enable
		private static MoveGigaDrain? _instance = null;
#nullable restore
        public static MoveGigaDrain Instance => _instance ?? (_instance = new MoveGigaDrain());

		public MoveGigaDrain() : base(
			"Giga-Drain",
			Grass.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 75,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}