using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//User foregoes its next turn to recharge.
	public class MoveMeteorAssault : Move
	{
		public MoveMeteorAssault() : base(
			"Meteor-Assault",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 150,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}