using Common.Abstracts;

namespace ProjectEuler.Problems
{
    internal class Problem_019 : Problem
    {
        public override object Solve()
        {
            var start = new DateTime(1901, 1, 1);

            var end = new DateTime(2000, 12, 31);

            var sundays = Enumerable.Range(0, 1 + end.Subtract(start).Days).Select(offset => start.AddDays(offset)).Where(x => x.DayOfWeek == DayOfWeek.Sunday && x.Day == 1);

            return sundays.Count();
        }
    }
}
