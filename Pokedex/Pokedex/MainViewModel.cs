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
        private PokemonService _pokemonService;

        public MainViewModel()
        {
            _pokemonService = new PokemonService();
        }

        public async Task InitAsync()
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

        private bool _isLoading;
        public bool IsLoading
        {
            get { return _isLoading; }
            set
            {
                _isLoading = value;
                OnPropertyChanged();
            }
        }

        private IEnumerable<SimplePokemon> _pokemons;
        public IEnumerable<SimplePokemon> Pokemons
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
