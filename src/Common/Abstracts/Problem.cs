using System.Diagnostics;

namespace Common.Abstracts
{
    public abstract class Problem
    {
        public abstract object Solve();
        public string GetSolution() => Solve().ToString() ?? "";

        public virtual void PrintSolution()
        {
            var stopWatch = new Stopwatch();
            Console.WriteLine($"--- {GetType().Name} ---");
            stopWatch.Start();
            Console.WriteLine($"Solution: {Solve()}");
            stopWatch.Stop();
            var elapsed = stopWatch.Elapsed;
            Console.WriteLine();
            Console.WriteLine($"Found in {elapsed.Minutes:D2}min, {elapsed.Seconds:D2}sec, {elapsed.Milliseconds:D3}ms");
            Console.WriteLine("-------------------");
            Console.WriteLine();
        }
    }
}
