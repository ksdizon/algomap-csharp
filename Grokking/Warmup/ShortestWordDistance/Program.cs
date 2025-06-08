namespace Grokking.Warmup.ShortestWordDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = new[] { "practice", "makes", "perfect", "coding", "makes" };
            ShortestWordDistance solver = new ShortestWordDistance();
            Console.WriteLine(solver.ShortestDistance(words, "coding", "practice"));
            Console.WriteLine(solver.ShortestDistance(words, "makes", "coding"));
        }
    }
}