using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveGlitzyGlow : Move
	{
#nullable enable
		private static MoveGlitzyGlow? _instance = null;
#nullable restore
        public static MoveGlitzyGlow Instance => _instance ?? (_instance = new MoveGlitzyGlow());

		public MoveGlitzyGlow() : base(
			"Glitzy-Glow",
			Psychic.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 80,// PP & Pow
			95, 0 // Acc & Priority
		) {}
	}
}