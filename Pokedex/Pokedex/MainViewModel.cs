using Pokedex.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Pokedex
{
    public class MainViewModel : ViewModelBase
    {
        private readonly PokemonService _pokemonService;

        public MainViewModel()
        {
            _pokemonService = new PokemonService();
        }

        public override async Task InitAsync()
        {
            try
            {
                IsLoading = true;

                var response = await _pokemonService.CatchEmAllAsync();
                Pokemons = response.Results;
            }
            finally
            {
                IsLoading = false;
            }
        }

        private IEnumerable<AdditionalInfo> _pokemons;
        public IEnumerable<AdditionalInfo> Pokemons
        {
            get { return _pokemons; }
            set
            {
                _pokemons = value;
                OnPropertyChanged();
            }
        }

        
    }
}
