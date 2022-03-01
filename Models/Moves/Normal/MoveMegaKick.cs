using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveMegaKick : Move
	{
		public MoveMegaKick() : base(
			"Mega-Kick",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 120,// PP & Pow
			0.75, 0 // Acc & Priority
		) {}
	}
}