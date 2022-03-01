using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveBulletPunch : Move
	{
		public MoveBulletPunch() : base(
			"Bullet-Punch",
			Steel.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			30, 40,// PP & Pow
			1.0, 1 // Acc & Priority
		) {}
	}
}