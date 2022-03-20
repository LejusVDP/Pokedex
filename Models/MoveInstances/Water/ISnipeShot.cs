using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ISnipeShot : MoveInstance
	{
		public ISnipeShot() : base( MoveSnipeShot.Instance ) {}
	}
}