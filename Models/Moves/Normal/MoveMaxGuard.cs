using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Prevents any moves from hitting the user this turn.
	public class MoveMaxGuard : Move
	{
#nullable enable
		private static MoveMaxGuard? _instance = null;
#nullable restore
        public static MoveMaxGuard Instance => _instance ?? (_instance = new MoveMaxGuard());

		public MoveMaxGuard() : base(
			"Max-Guard",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 4 // Acc & Priority
		) {}
	}
}