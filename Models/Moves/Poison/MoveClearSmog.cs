using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Removes all of the target's stat modifiers.
	public class MoveClearSmog : Move
	{
#nullable enable
		private static MoveClearSmog? _instance = null;
#nullable restore
        public static MoveClearSmog Instance => _instance ?? (_instance = new MoveClearSmog());

		public MoveClearSmog() : base(
			"Clear-Smog",
			Poison.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 50,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}