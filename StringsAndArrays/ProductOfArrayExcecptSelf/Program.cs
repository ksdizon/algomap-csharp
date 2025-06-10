namespace StringsAndArrays.ProductOArrayExceptSelf
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solver = new Solution();
            foreach (int n in solver.ProductExceptSelf(new[] { 1, 2, 3, 4 }))
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
        }
    }
}