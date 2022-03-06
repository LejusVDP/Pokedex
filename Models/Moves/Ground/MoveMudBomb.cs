using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to lower the target's accuracy by one stage.
	public class MoveMudBomb : Move
	{
		public MoveMudBomb() : base(
			"Mud-Bomb",
			Ground.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 65,// PP & Pow
			85, 0 // Acc & Priority
		) {}
	}
}