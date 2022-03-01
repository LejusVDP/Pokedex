using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage and can hit Dig users.
	public class MoveEarthquake : Move
	{
		public MoveEarthquake() : base(
			"Earthquake",
			Ground.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 100,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}