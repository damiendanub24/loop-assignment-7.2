namespace loop_assignment_7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PartOne();
            //PartTwo();
            PartThree();
        }
        public static void PartOne()
        {
            Console.WriteLine("Counting down to blast off");
            Console.WriteLine();
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Blast off!");
        }
        public static void PartTwo()
        {
            Console.WriteLine("X\tY");
            for (int x = 1; x <= 10; x++)
            {
                int y = x * x;
                Console.WriteLine($"{x}\t{y}");
            }
        }
        public static void PartThree()
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            int iterations = 10;
            if (name == "Damien")
            {
                iterations = 5;
            }
            for (int i = 0; i < iterations; i++)
            {
                Console.WriteLine(name);
            }
        }
    }
}
