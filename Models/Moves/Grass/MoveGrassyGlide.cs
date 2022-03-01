using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveGrassyGlide : Move
	{
		public MoveGrassyGlide() : base(
			"Grassy-Glide",
			Grass.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 70,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}