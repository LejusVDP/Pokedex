using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveSoulStealing7StarStrike : Move
	{
		public MoveSoulStealing7StarStrike() : base(
			"Soul-Stealing-7-Star-Strike",
			Ghost.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			1, 195,// PP & Pow
			null, 0 // Acc & Priority
			
		) {}
	}
}