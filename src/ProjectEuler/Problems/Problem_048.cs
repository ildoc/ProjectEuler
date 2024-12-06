using Common.Abstracts;
using Common.Extensions;
using System.Numerics;

namespace ProjectEuler.Problems
{
    internal class Problem_048 : Problem
    {
        public override object Solve()
        {
            BigInteger result = 0;

            foreach(var n in 1..1001)
            {
                result += BigInteger.Pow(n, n);
            }

            return result.ToString()[^10..];
        }
    }
}
