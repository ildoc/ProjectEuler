using Common.Abstracts;
using System.Numerics;

namespace ProjectEuler.Problems
{
    internal class Problem_016 : Problem
    {
        public override object Solve()
        {
            return BigInteger.Pow(2, 1000)
                .ToString()
                .Sum(char.GetNumericValue);
        }
    }
}
