using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the target's Attack and Special Attack by one stage.
	public class MoveNobleRoar : Move
	{
#nullable enable
		private static MoveNobleRoar? _instance = null;
#nullable restore
        public static MoveNobleRoar Instance => _instance ?? (_instance = new MoveNobleRoar());

		public MoveNobleRoar() : base(
			"Noble-Roar",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			30, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}