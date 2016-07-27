using Pokedex.Models;
using Pokedex.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    public class PokemonViewModel : ViewModelBase
    {
        private readonly PokemonService _pokemonService;
        private readonly AdditionalInfo _pokemon;

        public PokemonViewModel(AdditionalInfo pokemon)
        {
            _pokemon = pokemon;
            _pokemonService = new PokemonService();
        }

        public override async Task InitAsync()
        {
            try
            {
                IsLoading = true;
                Details = await _pokemonService.GetDetails(_pokemon.Url);
            }
            finally
            {
                IsLoading = false;
            }
        }

        private PokemonDetailsResponse _details;
        public PokemonDetailsResponse Details
        {
            get { return _details; }
            set
            {
                _details = value;
                OnPropertyChanged();
            }
        }

        public string Name
        {
            get { return _pokemon.Name; }
        }
    }
}
