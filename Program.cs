namespace dotnet_lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of items:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the seed:");
            int seed = int.Parse(Console.ReadLine());

            Problem problem = new Problem(n, seed);
            Console.WriteLine("\nGenerated Items:");
            Console.WriteLine(problem);

            Console.WriteLine("\nEnter backpack capacity:");
            int capacity = int.Parse(Console.ReadLine());

            Result result = problem.Solve(capacity);
            Console.WriteLine("\nSolution:");
            Console.WriteLine(result);
        }
    }
}
