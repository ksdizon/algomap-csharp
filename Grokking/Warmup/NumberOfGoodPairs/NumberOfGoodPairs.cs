namespace Grokking.Warmup.NumberOfGoodPairs
{
    public class NumberOfGoodPairs
    {
        public int GoodPairs(int[] nums)
        {
            Dictionary<int, int> appearances = new Dictionary<int, int>();
            int pairs = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (!appearances.ContainsKey(nums[i]))
                {
                    appearances.Add(nums[i], 1);
                }
                else
                {
                    appearances[nums[i]] += 1;
                }
            }

            foreach (var kvp in appearances)
            {
                int n = kvp.Value;
                pairs += n * (n - 1) / 2;
            }

            return pairs;
        }
    }
}