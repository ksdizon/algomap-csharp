namespace FindClosetsNumberToZero
{
    class Solution
    {
        public int FindClosestNumber(int[] nums)
        {
            int min = nums[0];

            foreach (int n in nums)
            {
                if (Math.Abs(n) < Math.Abs(min))
                {
                    min = n;
                }
            }

            if (nums.Contains(Math.Abs(min)))
            {
                return Math.Abs(min);
            }

            return min;
        }
    }
}