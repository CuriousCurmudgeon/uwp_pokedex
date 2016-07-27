using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    public class PokemonViewModel : ViewModelBase
    {
        private readonly SimplePokemon _pokemon;

        public PokemonViewModel(SimplePokemon pokemon)
        {
            _pokemon = pokemon;
        }

        public string Name
        {
            get { return _pokemon.Name; }
        }
    }
}
