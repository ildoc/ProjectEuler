using Common.Abstracts;
using Common.Utils;

namespace ProjectEuler.Problems
{
    internal class Problem_002 : Problem
    {
        public override object Solve()
        {
            return Fibonacci.GetLowerThan(4000000)
                 .Where(x => x % 2 == 0)
                 .Sum();
        }
    }
}
