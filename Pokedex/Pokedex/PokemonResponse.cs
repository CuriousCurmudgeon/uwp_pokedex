using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    public class PokemonResponse
    {
        public int Count { get; set; }

        public Uri Previous { get; set; }

        public Uri Next { get; set; }

        public IEnumerable<SimplePokemon> Results { get; set; }
    }
}
