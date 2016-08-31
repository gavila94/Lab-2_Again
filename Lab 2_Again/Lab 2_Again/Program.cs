using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_new
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! What is your name? (enter your name):");
            string name = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Would you like to play a game? (enter 'yes' or 'no')");
            string yesNo = Console.ReadLine();
            Console.WriteLine();

            if (yesNo == "yes")
            {
                Console.WriteLine("Excellent! You are walking across a field and you encounter a fire-breathing dragon! What would you do? (enter 'face the beast' or 'run away')\n");
                string dragon = Console.ReadLine();
                Console.WriteLine();

                switch (dragon)
                {
                    case "face the beast":
                        Console.WriteLine("You approach the dragon. You see that he has ____ heads. (Enter '1' or '2' or '3'):\n");
                        decimal heads = decimal.Parse(Console.ReadLine());
                        if (heads > 3 || heads < 1)

                        {

                            Console.WriteLine("That type of dragon doesn't exist. Thanks for playing.");

                            break;
                        }

                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine($"No one has ever faced a {heads} -headed dragon before!");

                            Console.WriteLine("Choose your weapon. (enter 'slingshot' or 'sword' or 'bow and arrow')");
                            string weapon = Console.ReadLine();


                            if (weapon == "slingshot" || weapon == "sword" || weapon == "bow and arrow")
                            {
                                Console.WriteLine();
                                Console.WriteLine($"Armed with your {weapon}, you approach the dragon. You can feel its fiery breath as you get closer. It stares at you with its ___ eyes. (enter 'red' or 'blue')\n");
                            }
                            else

                                Console.WriteLine("That weapon does not exist. Thanks for playing");

                            break;
                        }



                    case "run away":
                        Console.WriteLine($"Better to be safe than sorry. Thanks for playing, {name}.");
                        break;
                    default:
                        break;

                }
                string eyes = Console.ReadLine();
                Console.WriteLine();
                switch (eyes)
                {
                    case "red":
                        Console.WriteLine($"Oh thank goodness! {eyes}-eyed dragons are friendly. You pet it and become friends. You name the dragon ____. (enter a name)");
                        string dragonName = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine($"{name} and {dragonName} live happily ever after");
                        Console.WriteLine();
                        break;
                    case "blue":
                        Console.WriteLine($"Blue-eyed dragons are not friendly. The story has ended for you, {name}. Thanks for playing!");
                        break;
                }


            }
            else
            {
                Console.WriteLine("Have a nice day");
            }
        }
    }
}
