using Flurl;
using Flurl.Http;
using Pokedex.Responses;
using System;
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

        public async Task<PokemonDetailsResponse> GetDetails(Uri url)
        {
            var flurlUrl = new Url(url.AbsoluteUri);
            return await flurlUrl.GetJsonAsync<PokemonDetailsResponse>();
        }
    }
}
