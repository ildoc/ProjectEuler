namespace Common.Utils
{
    public static class Fibonacci
    {
        public static IEnumerable<int> GetFirst(int limit)
        {
            var result = new List<int> { 1, 2 };

            for (var i = 2; result.Count < limit; i++)
            {
                result.Add(result[i - 1] + result[i - 2]);
            }
            return result;
        }

        public static IEnumerable<int> GetLowerThan(int max)
        {
            var result = new List<int> { 1, 2 };

            var i = 2;
            while (true)
            {
                var newNum = result[i - 1] + result[i - 2];

                if (newNum > max) break;
                
                result.Add(newNum);
                i++;
            }
            return result;
        }
    }
}
