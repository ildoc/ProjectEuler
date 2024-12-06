using Common.Abstracts;
using Common.Extensions;
using Common.Utils;

namespace ProjectEuler.Problems
{
    internal class Problem_035 : Problem
    {
        public override object Solve()
        {
            var primes = Primes.GetPrimesUnderN(1000000);

            var count = 0;
            foreach (var prime in primes)
            {
                if (prime.GetCirculars().All(x => primes.Contains(x)))
                    count++;
            }

            return count;
        }
    }
}
