using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Raises the user's Defense by one stage.
	public class MoveHarden : Move
	{
#nullable enable
		private static MoveHarden? _instance = null;
#nullable restore
        public static MoveHarden Instance => _instance ?? (_instance = new MoveHarden());

		public MoveHarden() : base(
			"Harden",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			30, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}