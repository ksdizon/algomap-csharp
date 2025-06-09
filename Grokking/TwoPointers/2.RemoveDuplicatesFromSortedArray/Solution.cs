namespace _2.RemoveDuplicatesFromSortedArray
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            int slow = 0, fast = nums.Length - 1;
            int k = 0;

            while (fast < nums.Length)
            {
                if (nums[slow] != nums[fast])
                {
                    slow++;
                    nums[slow] = nums[fast];
                    k++;
                }

                fast++;
            }

            return slow + 1;
        }
    }
}