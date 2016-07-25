using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    public class PokemonService
    {
        private const string HOST = "https://pokeapi.co/";
        private const string POKEMON_PATH = "/api/v2/pokemon";

        public async Task<PokemonResponse> CatchEmAllAsync()
        {
            // The bare minimum. There is no error handling here.
            var url = HOST + POKEMON_PATH;
            return await url.GetJsonAsync<PokemonResponse>();
        }
    }
}
