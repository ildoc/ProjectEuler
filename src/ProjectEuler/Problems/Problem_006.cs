using Common.Abstracts;

namespace ProjectEuler.Problems
{
    internal class Problem_006 : Problem
    {
        public override object Solve()
        {
            var limit = 100;

            var sumOfSquares = Enumerable.Range(1, limit).Sum(x => Math.Pow(x, 2));

            var squareOfSum = Math.Pow(Enumerable.Range(1, limit).Sum(), 2);

            return Convert.ToInt32(squareOfSum - sumOfSquares);
        }
    }
}
