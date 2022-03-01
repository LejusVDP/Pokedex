using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//User faints.
	public class MoveExplosion : Move
	{
		public MoveExplosion() : base(
			"Explosion",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 250,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}