namespace StringsAndArrays.ProductOArrayExceptSelf
{
    public class Solution
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] ans = new int[nums.Length];

            int leftProd = 1, rightProd = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                ans[i] = leftProd;
                leftProd *= nums[i];
            }

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                ans[i] *= rightProd;
                rightProd *= nums[i];
            }

            return ans;
        }
    }
}