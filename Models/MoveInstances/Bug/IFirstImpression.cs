using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IFirstImpression : MoveInstance
	{
		public IFirstImpression() : base( MoveFirstImpression.Instance ) {}
	}
}