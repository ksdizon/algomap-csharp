namespace Grokking.Warmup.NumberOfGoodPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 1, 1, 3 };
            NumberOfGoodPairs solver = new NumberOfGoodPairs();
            Console.WriteLine(solver.GoodPairs(nums));
            Console.WriteLine(solver.GoodPairs(new int[] {1,1,1,1}));
        }    
    }
}