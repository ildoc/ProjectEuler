using Common.Abstracts;
using Common.Extensions;
using Common.Utils;

namespace ProjectEuler.Problems
{
    internal class Problem_007 : Problem
    {
        public override object Solve()
        {
            return Primes.GetPrimes(10001).Max();
        }
    }
}
