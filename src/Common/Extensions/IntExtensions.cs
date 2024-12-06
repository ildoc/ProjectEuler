namespace Common.Extensions
{
    public static class IntExtensions
    {
        public static List<int> GetCirculars(this int n)
        {
            var s = n.ToString();

            var result = new List<int> { n };
            if (s.Length == 1) return result;

            for (var i = 1; i < s.Length; i++)
            {
                s = s[1..] + s[0];
                result.Add(int.Parse(s));
            }

            return result;
        }
    }
}
