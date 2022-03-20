using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveCoaching : Move
	{
#nullable enable
		private static MoveCoaching? _instance = null;
#nullable restore
        public static MoveCoaching Instance => _instance ?? (_instance = new MoveCoaching());

		public MoveCoaching() : base(
			"Coaching",
			Fighting.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}