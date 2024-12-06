using Common.Abstracts;
using Common.Utils;

namespace ProjectEuler.Problems
{
    internal class Problem_003 : Problem
    {
        public override object Solve()
        {
            var primes = 600851475143.Factorize();
            return primes.Max();
        }
    }
}
