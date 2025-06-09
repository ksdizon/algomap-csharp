namespace _1.TwoSumII
{
    public class Solution
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int head = 0, tail = numbers.Length - 1;

            while (head < tail)
            {
                if (numbers[head] + numbers[tail] == target)
                {
                    return new int[] { head + 1, tail + 1 };
                }

                if (numbers[head] + numbers[tail] < target)
                {
                    head++;
                }
                else
                {
                    tail--;
                }
            }

            return [];
        }
    }
}