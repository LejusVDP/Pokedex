using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Prevents the target from fleeing and inflicts damage for 2-5 turns.
	public class MoveFireSpin : Move
	{
#nullable enable
		private static MoveFireSpin? _instance = null;
#nullable restore
        public static MoveFireSpin Instance => _instance ?? (_instance = new MoveFireSpin());

		public MoveFireSpin() : base(
			"Fire-Spin",
			Fire.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 35,// PP & Pow
			85, 0 // Acc & Priority
		) {}
	}
}