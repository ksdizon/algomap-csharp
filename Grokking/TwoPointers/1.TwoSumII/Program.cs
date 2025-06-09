namespace _1.TwoSumII
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            Solution solver = new Solution();
            int[] result = solver.TwoSum(nums, target);

            if (result[0] == -1)
            {
                Console.WriteLine("No solution");
            }
            else
            {
                Console.WriteLine($"[{result[0]}, {result[1]}]");
            }
        }
    }
}