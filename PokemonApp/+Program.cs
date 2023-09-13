namespace PokemonApp
{
    internal class Program
    {
        // Encapsulation Pelare 1:
        // Encapuslation referer to the bundleing of date and methods that operate on the data into a single unit called class.
        // Moreover, it restricts direct access to some of the objects componets which prevents uninteded interfereranse and missuse of data

        //Scope {This is within the scope}

        //Access Modifiers
        //1. Public: A public variable/method/class can be accessed from anyonther code in the same assembly/namespace
        //2. Private: The variable/method/class is only accessible within its own class.
        //3. Protected: The variable/method/class is accessible within its own class and derived classes.
        //4. Internal: The variable/method/class can be accessed by any code in the same assembly but not from another assembly.
        //5. Protected Internal: The variable/method/class can be accessed by any code in the assebly in which its DECLARED or from within a derived class in another assebly.


        static void Main(string[] args)
        {
            Game game = new Game();
            game.CatchEmAll();
            game.DisplayAshPokemons();  

            Trainer ash = new Trainer("Ash");
            //Trainer misty = new Trainer("Misty");

            //ash.CatchPokemon(pikachu);
            //misty.CatchPokemon(bulbasaur);

            //Console.WriteLine($"{ash.GetName()} has {ash.GetTeam()[0].GetName()} on his team, with {ash.GetTeam()[0].GetHealth()} hp");
            //Console.WriteLine($"{misty.GetName()} has {misty.GetTeam()[0].GetName()} on his team, with {ash.GetTeam()[0].GetHealth()} hp\n");

            //Console.WriteLine($"A Battle has begun between the two trainers {ash.GetName()} and {misty.GetName()}\n");

            //Console.WriteLine($"{ash.GetName()} commands {ash.GetTeam()[0].GetName()} to attack!");
            //ash.GetTeam()[0].Attack(bulbasaur);
            //Console.WriteLine($"{misty.GetName()}s {misty.GetTeam()[0].GetName()} now has {misty.GetTeam()[0].GetHealth()}hp\n");

            //Console.WriteLine("Misty Retaliate!\n");

            //Console.WriteLine($"{misty.GetName()} commands her {misty.GetTeam()[0].GetName()} to attack!");
            //misty.GetTeam()[0].Attack(pikachu);
            //Console.WriteLine($"{ash.GetTeam()[0].GetName()} now has {ash.GetTeam()[0].GetHealth()}");

            

        }


    }
}