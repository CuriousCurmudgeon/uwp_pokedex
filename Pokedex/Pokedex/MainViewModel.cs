using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private PokemonService _pokemonService;

        // Setting an empty delegate is not strictly necessary, but it removes the need
        // for null checks for a miniscule performance hit.
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public MainViewModel()
        {
            _pokemonService = new PokemonService();
            Test = "Test Text";
        }

        public async Task InitAsync()
        {
            var response = await _pokemonService.CatchEmAllAsync();
            _pokemons = response.Results;
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

        private string _test;
        public string Test
        {
            get { return _test; }
            set
            {
                _test = value;
                OnPropertyChanged();
            }
        }

        // Manually setup property change notification so that the UI will be notified when values change.
        // This allows bound values to update in the UI.
        // I would usually use a framework like MvvmLight or MvvmCross to handle this for me.
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
