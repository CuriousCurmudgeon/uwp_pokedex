using Pokedex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Responses
{
    public class PokemonDetailsResponse
    {
        public PokemonDetailsResponse()
        {
            Types = new List<PokemonType>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Weight { get; set; }

        public PokemonSprites Sprites { get; set; }

        public IEnumerable<PokemonType> Types { get; set; }
    }
}
