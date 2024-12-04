namespace ProjectEuler.Problems
{
    internal class P1
    {
        public static int Solve()
        {
            var result = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    result += i;
                }

            }
            return result;
        }
    }
}
