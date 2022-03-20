using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to lower the target's accuracy by one stage.
	public class MoveMirrorShot : Move
	{
#nullable enable
		private static MoveMirrorShot? _instance = null;
#nullable restore
        public static MoveMirrorShot Instance => _instance ?? (_instance = new MoveMirrorShot());

		public MoveMirrorShot() : base(
			"Mirror-Shot",
			Steel.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 65,// PP & Pow
			85, 0 // Acc & Priority
		) {}
	}
}