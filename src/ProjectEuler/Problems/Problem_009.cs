using Common.Abstracts;
using Common.Extensions;

namespace ProjectEuler.Problems
{
    internal class Problem_009 : Problem
    {
        public override object Solve()
        {
            var range = 1..500;

            foreach (var a in range)
                foreach (var b in range)
                {
                    var c = (1000 - a - b);
                    if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
                        return a * b * c;
                }
            return 0;
        }
    }
}
