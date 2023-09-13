using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApp
{
    internal class Trainer
    {
        private string TrainerName;
        private List<Pokemon> Team;

        public Trainer (string trainerName)
        {
            this.TrainerName = trainerName;
            Team = new List<Pokemon> ();
        }

        public void CatchPokemon(Pokemon pokemon)
        {
            Console.WriteLine($"Thats a Catch! {TrainerName} as managed to catch the Pokemon {pokemon.GetName()} and is now added to the team!");
            Team.Add ( pokemon );
        }

        public string GetName() { return TrainerName; }

        public List<Pokemon> GetTeam() {  return Team; }



    }
}
