using Common.Abstracts;

namespace ProjectEuler.Problems
{
    internal class Problem_005 : Problem
    {
        public override object Solve()
        {
            var numbers = Enumerable.Range(2, 20);

            var i = 20;
            while (true)
            {
                if (numbers.All(x => i % x == 0)) break;
                i += 20;
            }

            return i;
        }
    }
}
