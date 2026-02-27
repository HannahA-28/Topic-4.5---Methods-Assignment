namespace Topic_4._5___Methods_Assignment
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string choice;
            Console.WriteLine("Hello, pick which image you want to see!");
            Console.WriteLine("1 is a car, 2 is a dog, and 3 is mountains");
            choice = Console.ReadLine();
            if (choice == "1")
                Car();
            else if (choice == "2")
                Dog();
            else if (choice == "3")
                Mountains();

            Joke();
        }

        public static void Car()
        {
            Console.WriteLine("  ______");
            Console.WriteLine(" /|_||_|`.__");
            Console.WriteLine("(   _    _ _\\");
            Console.WriteLine("=`-(_)--(_)-' ");
        }

        public static void Dog()
        {
            Console.WriteLine("  __      _");
            Console.WriteLine("o'')}____//");
            Console.WriteLine(" `_/      )");
            Console.WriteLine(" (_(_/-(_/");
        }

        public static void Mountains()
        {
            Console.WriteLine("          /\\");
            Console.WriteLine("         /**\\");
            Console.WriteLine("        /****\\   /\\");
            Console.WriteLine("       /      \\ /**\\");
            Console.WriteLine("      /  /\\    /    \\     ");
            Console.WriteLine("     /  /  \\  /      \\    ");
            Console.WriteLine("    /  /    \\/ /\\     \\   ");
            Console.WriteLine("   /  /      \\/  \\/\\   \\  ");
            Console.WriteLine("  /__/_______/___/__\\___\\");
        }


        public static void Joke()
        {
            Console.WriteLine();
            Console.WriteLine("Knock Knock");
            Console.ReadLine();
            Thread.Sleep(3000);
            Console.WriteLine("Lettuce");
            Console.ReadLine();
            Thread.Sleep(3000);
            Console.WriteLine("Lettuce in! It's cold out here!"); 
        }
    }
}
