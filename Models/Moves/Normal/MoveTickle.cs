using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the target's Attack and Defense by one stage.
	public class MoveTickle : Move
	{
#nullable enable
		private static MoveTickle? _instance = null;
#nullable restore
        public static MoveTickle Instance => _instance ?? (_instance = new MoveTickle());

		public MoveTickle() : base(
			"Tickle",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}