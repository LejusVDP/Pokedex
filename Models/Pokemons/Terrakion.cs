using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Terrakion Specie to store common natural stats of all Terrakions
	#region SpecieTerrakion
	public class SpecieTerrakion : PokemonSpecie
	{
#nullable enable
		private static SpecieTerrakion? _instance = null;
#nullable restore
        public static SpecieTerrakion Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTerrakion();
                }
                return _instance;
            }
        }

		#region SpecieTerrakion Builder
		public SpecieTerrakion() : base(
			"Terrakion",
			91, // HPs
			129, 90, // Attack & Defense
			72, 90, // Special Attack & Defense
			108		
		)
		{
			this._height = 19;
			this._weight = 2600;
		}
		#endregion
	}
	#endregion

	//Terrakion Pokemon Class
	#region Terrakion
	public class Terrakion : Pokemon
	{
		#region Terrakion Builders
		/// <summary>
		/// Terrakion Builder waiting for a Nickname & a Level
		/// </summary>
		public Terrakion(string nickname, int level)
		: base(
				639,
				SpecieTerrakion.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Terrakion Builder only waiting for a Level
		/// </summary>
		public Terrakion(int level)
		: base(
				639,
				SpecieTerrakion.Instance, // Pokemon Specie
				"Terrakion", level,
				Rock.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Terrakion Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Terrakion() : base(
			639,
			SpecieTerrakion.Instance, // Pokemon Specie
			Rock.Instance, Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}