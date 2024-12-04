using Common.Utils;

namespace ProjectEuler.Problems
{
    internal class P2
    {
        public static int Solve()
        {
           return Fibonacci.GetLowerThan(4000000)
                .Where(x => x % 2 == 0)
                .Sum();
        }
    }
}
