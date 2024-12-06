using Common.Abstracts;

namespace ProjectEuler.Problems
{
    internal class Problem_014 : Problem
    {
        public override object Solve()
        {
            var n = 1L;
            (long n, int count) res = (0, 0);
            while (n < 1000000)
            {
                var chain = GetChain(n);
                if (chain.Count > res.count) res = (n, chain.Count);
                n++;
            }

            return res.n;
        }

        private List<long> GetChain(long i)
        {
            var result = new List<long> { i };

            while (result[^1] != 1)
            {
                var last = result[^1];

                if (last < 0) throw new Exception();

                if (last % 2 == 0) result.Add(last /= 2);
                else result.Add((3 * last) + 1);
            }

            return result;
        }
    }
}
