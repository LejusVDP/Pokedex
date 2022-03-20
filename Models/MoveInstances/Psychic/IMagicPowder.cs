using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IMagicPowder : MoveInstance
	{
		public IMagicPowder() : base( MoveMagicPowder.Instance ) {}
	}
}