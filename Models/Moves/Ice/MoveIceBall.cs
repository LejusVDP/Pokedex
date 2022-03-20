using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Power doubles every turn this move is used in succession after the first, resetting after five turns.
	public class MoveIceBall : Move
	{
#nullable enable
		private static MoveIceBall? _instance = null;
#nullable restore
        public static MoveIceBall Instance => _instance ?? (_instance = new MoveIceBall());

		public MoveIceBall() : base(
			"Ice-Ball",
			Ice.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 30,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}