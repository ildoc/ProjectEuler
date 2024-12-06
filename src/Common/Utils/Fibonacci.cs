using System.Collections.Generic;

namespace Common.Utils
{
    public static class Fibonacci
    {
        public static IEnumerable<long> GetFirst(int limit)
        {
            var gen = FibonacciGenerator<long>();
            return gen.Take(limit);

        }

        public static IEnumerable<int> GetLowerThan(int max)
        {
            var gen = FibonacciGenerator<int>();
            return gen.TakeWhile(x => x < max);
        }

        public static IEnumerable<T> FibonacciGenerator<T>() where T : struct, IConvertible
        {
            dynamic current = 1;
            dynamic next = 1;

            while (true)
            {
                yield return current;
                dynamic temp = next;
                next = current + next;
                current = temp;
            }
        }
    }
}
