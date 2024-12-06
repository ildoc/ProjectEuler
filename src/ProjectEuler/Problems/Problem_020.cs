using Common.Abstracts;
using System.Numerics;

namespace ProjectEuler.Problems
{
    internal class Problem_020 : Problem
    {
        public override object Solve()
        {
            var n = 100;
            BigInteger res = 1;
            for (var i = 1; i < n; i++)
            {
                res *= i;
            }

            return res.ToString().Sum(char.GetNumericValue);
        }
    }
}
