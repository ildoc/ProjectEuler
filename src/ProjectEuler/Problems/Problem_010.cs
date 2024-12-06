using Common.Abstracts;
using Common.Utils;

namespace ProjectEuler.Problems
{
    internal class Problem_010 : Problem
    {
        public override object Solve()
        {
            return Primes.GetPrimesUnderN((long)2000000).Sum();
        }
    }
}
