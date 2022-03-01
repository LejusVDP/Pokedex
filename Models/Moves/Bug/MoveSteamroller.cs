using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to make the target flinch.
	public class MoveSteamroller : Move
	{
		public MoveSteamroller() : base(
			"Steamroller",
			Bug.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 65,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}