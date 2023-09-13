using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApp
{
    internal class Pokemon
    {
        private string Name;
        private PokemonType Type;
        private int Health;
        private string AttackOne;
        private string AttackTwo;

        public Pokemon(string name, PokemonType type, int health, string attackOne, string attackTwo)
        {
            this.Name = name;
            this.Type = type;
            this.Health = health;
            this.AttackOne = attackOne;
            this.AttackTwo = attackTwo;
        }

        public Pokemon(string name, PokemonType type, int health, string attackOne)
        {
            this.Name = name;
            this.Type = type;
            this.Health = health;
            this.AttackOne = attackOne;
        }

        public void Attack(Pokemon enemy)
        {
            //Here you can if you want make a complicated battle
            //For simplicity sake, decrease value by 10 each attack.
            Console.WriteLine("Ouch! That gotta hurt!");
            enemy.Health -= 10;

        }

        public void Attack2(Pokemon enemy)
        {
            //Here you can if you want make a complicated battle
            //For simplicity sake, decrease value by 10 each attack.
            Console.WriteLine("Ouch! That gotta hurt!");
            enemy.Health -= 20;

        }

        public void RestoreHealth()
        {
            this.Health = 100;
        }



        


        public string GetName() 
        { 
            return this.Name; 
        }

        public PokemonType GetType()
        {
            return this.Type;
        }

        public int GetHealth()
        {
            return this.Health;
        }

        public void FullInfo()
        {
            Console.WriteLine($"The name of your Pokemon is {this.Name} of the type {this.Type} with {this.Health} Hp");
            
        }
    }
}
