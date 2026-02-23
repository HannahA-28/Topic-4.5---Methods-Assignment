namespace Topic_4._5___Methods_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, pick which image you want to see!");
            Console.ReadLine();
            Car();
            Dog();
            Moutains();
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

        public static void Moutains()
        {
            Console.WriteLine("          /\\");
            Console.WriteLine("         /**\\");
            Console.WriteLine("        /****\\   /\\");
            Console.WriteLine("       /      \\ /**\\");
            Console.WriteLine("      /  /\\    /    \\     ");
            Console.WriteLine("     /  /  \\  /      \\    ");
            Console.WriteLine("    /  /    \\/ /\\    \\   ");
            Console.WriteLine("   /  /      \\/  \\/\\ \\  ");
            Console.WriteLine("__/__/________/___/___\\_\\");
        }
    }
}
