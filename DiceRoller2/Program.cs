namespace DiceRoller2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, welcome to Super Dice!");
            bool goOn = true;

            do
            {
                Console.WriteLine();
                Console.WriteLine("Please choose how many sides you would like the dice to have");
                int side = 0;
                int sides = MustBePositive(side);
                int die1 = Random(sides);
                int die2 = Random(sides);


                if (sides == 6)
                {
                    Console.WriteLine();
                    RollingSix(sides);
                    goOn = Continue();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"You rolled two {sides} sided dice");
                    Console.WriteLine();
                    Console.WriteLine($"The dice read {die1} and {die2}");
                    Console.WriteLine();
                    goOn = Continue();

                }
            }
            while (goOn == true);
        }
        public static int Random(int num1)
        {
            Random rnd = new Random();
            Random rnd2 = new Random();
            return rnd.Next(1, num1);


        }

        public static int MustBePositive(int sides)
        {
            {
                while (!int.TryParse(Console.ReadLine(), out sides) || sides <= 0)

                {
                    Console.WriteLine("Error: Number of Items must be a positive, whole number");

                }
                return sides;
            }
        }

        public static void RollingSix(int num)
        {
            int die1 = Random(num);
            int die2 = Random(num);
            Console.WriteLine($"You rolled two {num} sided dice");
            Console.WriteLine();
            Console.WriteLine($"The dice read {die1} and {die2}");
            Console.WriteLine();
            if (die1 == 1 && die2 == 1)
            {
                Console.WriteLine("Snake Eyes");
            }
            else if ((die1 == 2 && die2 == 1) || (die1 == 1 && die2 == 2))
            {
                Console.WriteLine("Ace Deuce");
            }
            else if (die1 == 6 && die2 == 6)
            {
                Console.WriteLine("Boxcars");
            }
            else if ((die1 + die2 == 7) || (die1 + die2 == 11))
            {
                Console.WriteLine("Win!!!");
            }
            else { Console.WriteLine(""); }
        }
        public static bool Continue()
        {
            Console.WriteLine("Would you like to roll again?  y/n ");
            string input = Console.ReadLine().ToLower().Trim();

            if (input == "y")
            {
                return true;
            }
            else if (input == "n")
            {

                return false;
            }
            else
            {
                Console.WriteLine("Type \"y\" to roll again, type \"n\" to stop");
                return Continue();
            }
        }


    }

}