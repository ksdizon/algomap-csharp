namespace Grokking.Warmup.ShortestWordDistance
{
    public class ShortestWordDistance
    {
        public int ShortestDistance(string[] words, string w1, string w2)
        {
            int index1 = -1, index2 = -1;
            int min = int.MaxValue;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == w1)
                {
                    index1 = i;
                }
                else if (words[i] == w2)
                {
                    index2 = i;
                }

                if (index1 != -1 && index2 != -1)
                {
                    min = Math.Abs(index1 - index2) < min ? Math.Abs(index1 - index2) : min;
                }
            }
            return min;
        }
    }
}