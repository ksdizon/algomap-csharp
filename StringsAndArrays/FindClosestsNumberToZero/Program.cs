namespace FindClosetsNumberToZero
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solver = new Solution();
            Console.WriteLine(solver.FindClosestNumber(new int[]{ -4, -2, 1, 4, 8 }));
        }
    }
}