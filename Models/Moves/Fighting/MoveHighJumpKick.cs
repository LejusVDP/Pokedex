using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//If the user misses, it takes half the damage it would have inflicted in recoil.
	public class MoveHighJumpKick : Move
	{
#nullable enable
		private static MoveHighJumpKick? _instance = null;
#nullable restore
        public static MoveHighJumpKick Instance => _instance ?? (_instance = new MoveHighJumpKick());

		public MoveHighJumpKick() : base(
			"High-Jump-Kick",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 130,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}