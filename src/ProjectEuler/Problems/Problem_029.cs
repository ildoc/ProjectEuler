using Common.Abstracts;
using Common.Extensions;
using Common.Utils;
using System.Numerics;

namespace ProjectEuler.Problems
{
    internal class Problem_029 : Problem
    {
        public override object Solve()
        {
            var a = 2;
            var b = 100;

            var results = new List<BigInteger>();

            foreach(var x in a..(b+1))
            {
                foreach (var y in a..(b+1))
                    results.Add(BigInteger.Pow(x,y));
            }

            return results.Distinct().Count();
        }
    }
}
