using Common.Abstracts;
using Common.Extensions;

namespace ProjectEuler.Problems
{
    internal class Problem_004 : Problem
    {
        public override object Solve()
        {
            var n = 0;
            var s = "";

            var range = 999..100;

            foreach (var x in range)
            {
                foreach (var y in range)
                {
                    s = (x * y).ToString();
                    if (s.Reverse() == s)
                        if (x * y > n) n = x * y;
                }
            }
            return n;
        }
    }
}
