using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//User vanishes, dodging all attacks, and hits next turn.  Hits through Protect and Detect.
	public class MovePhantomForce : Move
	{
		public MovePhantomForce() : base(
			"Phantom-Force",
			Ghost.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 90,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}