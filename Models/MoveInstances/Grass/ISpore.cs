using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ISpore : MoveInstance
	{
		public ISpore() : base( MoveSpore.Instance ) {}
	}
}