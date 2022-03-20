using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Heals the target for ½ its max HP, or ⅔ on Grassy Terrain.
	public class MoveFloralHealing : Move
	{
#nullable enable
		private static MoveFloralHealing? _instance = null;
#nullable restore
        public static MoveFloralHealing Instance => _instance ?? (_instance = new MoveFloralHealing());

		public MoveFloralHealing() : base(
			"Floral-Healing",
			Fairy.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}