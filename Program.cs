class Program
{
    static void Main(string[] args)
    {
        int score = 0;
        Console.WriteLine("==== Math Test ====");
        Console.WriteLine("1) 2 + 2 = ?");
        int answer1 = Convert.ToInt16(Console.ReadLine());
        if (answer1 == 4)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Wrong!");
        }
        Console.ResetColor();
        Console.WriteLine("2) 5 * 3 = ?");
        int answer2 = Convert.ToInt16(Console.ReadLine());
        if (answer2 == 15)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Wrong!");
        }
        Console.ResetColor();
        Console.WriteLine("3) 10 - 7 = ?");
        int answer3 = Convert.ToInt16(Console.ReadLine());
        if (answer3 == 3)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Wrong!");
        }
        Console.ResetColor();
        Console.WriteLine("4) 12 / 4 = ?");
        int answer4 = Convert.ToInt16(Console.ReadLine());
        if (answer4 == 3)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Wrong!");
        }
        Console.ResetColor();
        Console.WriteLine("5) 9 + 1 = ?");
        int answer5 = Convert.ToInt16(Console.ReadLine());
        if (answer5 == 10)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Wrong!");
        }
        Console.ResetColor();
        Console.WriteLine($"\nYour score: 5/{score}");
    }
}
