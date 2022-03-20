using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IStompingTantrum : MoveInstance
	{
		public IStompingTantrum() : base( MoveStompingTantrum.Instance ) {}
	}
}