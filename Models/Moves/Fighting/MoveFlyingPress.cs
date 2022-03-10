using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Deals both fighting and flying-type damage.
	public class MoveFlyingPress : Move
	{
		public MoveFlyingPress() : base(
			"Flying-Press",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 100,// PP & Pow
			95, 0 // Acc & Priority
		) {}
	}
}