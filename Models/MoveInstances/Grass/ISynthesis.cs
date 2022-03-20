using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ISynthesis : MoveInstance
	{
		public ISynthesis() : base( MoveSynthesis.Instance ) {}
	}
}