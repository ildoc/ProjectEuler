using Common.Abstracts;
using FluentAssertions;
using ProjectEuler.Problems;

namespace ProjectEuler.Tests.Unit
{
    public class Solutions
    {
        [Theory]
        [MemberData(nameof(ProblemSolutions))]
        public void ProblemShouldSolveCorrectly(int problemNumber, string solution)
        {
            var problem = typeof(Problem_001).Assembly
                .GetTypes()
                .FirstOrDefault(t => t.IsClass && !t.IsAbstract && typeof(Problem).IsAssignableFrom(t) && t.Name.EndsWith($"_{problemNumber:D3}"));

            problem.Should().NotBeNull();

            var p = (Problem)Activator.CreateInstance(problem);
            var result = p?.GetSolution();

            result.Should().NotBeNull();
            result.Should().Be(solution);
        }

        public static IEnumerable<object[]> ProblemSolutions
        {
            get
            {
                // spoiler!
                var solutions = new Dictionary<int, string>
                {
                    { 1, "233168" },
                    { 2, "4613732" },
                    { 3, "6857" },
                    { 4, "906609" },
                    { 5, "232792560" },
                    { 6, "25164150" },
                    { 7, "104743" },
                    { 8, "23514624000" },
                    { 9, "31875000" },
                    { 10, "142913828922" },
                    { 13, "5537376230" },
                    { 14, "837799" },
                    { 16, "1366" },
                    { 19, "171" },
                    { 20, "648" },
                    { 29, "9183" },
                    { 35, "55" },
                    { 48, "9110846700" }
                };

                foreach (var s in solutions) yield return new object[] { s.Key, s.Value };
            }
        }
    }
}