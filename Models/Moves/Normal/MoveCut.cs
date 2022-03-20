using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveCut : Move
	{
#nullable enable
		private static MoveCut? _instance = null;
#nullable restore
        public static MoveCut Instance => _instance ?? (_instance = new MoveCut());

		public MoveCut() : base(
			"Cut",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			30, 50,// PP & Pow
			95, 0 // Acc & Priority
		) {}
	}
}