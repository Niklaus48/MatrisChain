

namespace MatrisChain
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        //Up To Down
        public static int matrisChain(int[] P, int first, int last, int[,] r)
        {
            if (first == last)
                return 0;

            if (r[first, last] > 0)
                return r[first, last];

            int min = int.MaxValue;
            for (int k = first; k < last; k++)
            {
                int q = matrisChain(P, first, k, r) + matrisChain(P, k + 1, last + 1, r) + P[first] * P[k + 1] * P[last + 1];

                if (q < min)
                {
                    min = q;
                }
            }
            r[first, last] = min;

            return min;
        }

       //Learn Down To Up
    }
}
