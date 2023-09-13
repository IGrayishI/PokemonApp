using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApp
{
    internal class Game
    {

        List<Pokemon> AllPokemons = new List<Pokemon>();
        Trainer ash = new Trainer("Ash");

        public Game()
        {
            SetUpPokemon();
        }

        public void SetUpPokemon()
        {
            Pokemon pikachu = new Pokemon("Pikachu", PokemonType.Electric, 100, "QuickAttack", "Thunderbolt");
            Pokemon bulbasaur = new Pokemon("Bulbasaur", PokemonType.Grass, 100, "Vine Whip", "Razorleaf");
            Pokemon charmander = new Pokemon("Charmander", PokemonType.Fire, 100, "Swipe", "Firebreath");
            Pokemon charizard = new Pokemon("Charizard", PokemonType.Fire, 100, "Flamethrower");
            Pokemon magicarp = new Pokemon("Magicarp", PokemonType.Water, 100, "Splash");
            Pokemon squirtle = new Pokemon("Squirtle", PokemonType.Water, 100, "Tackle", "Watergun");

            AllPokemons.Add(pikachu);
            AllPokemons.Add(bulbasaur);
            AllPokemons.Add(charmander);
            AllPokemons.Add(charizard);
            AllPokemons.Add(squirtle);
            AllPokemons.Add(magicarp);
           
        }

        public void CatchEmAll()
        {
            for (int i = 0; i < AllPokemons.Count; i++)
            {
                ash.CatchPokemon(AllPokemons[i]);
            }
        }

        public void DisplayAshPokemons()
        {
            for (int i = 0;i < ash.GetTeam().Count;i++)
            {
                Console.WriteLine(ash.GetTeam()[i].GetName());
            }
        }


    }
}
