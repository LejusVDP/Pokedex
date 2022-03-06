using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveTectonicRagePhysical : Move
	{
		public MoveTectonicRagePhysical() : base(
			"Tectonic-Rage--Physical",
			Ground.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			1, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}