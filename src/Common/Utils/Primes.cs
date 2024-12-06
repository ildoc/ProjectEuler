using Common.Extensions;

namespace Common.Utils
{
    public static class Primes
    {
        public static ICollection<int> GetPrimes(int max)
        {
            var n = 3;
            var result = new List<int> { 2 };
            var prime = true;
            while (result.Count < max)
            {
                prime = true;
                foreach (var x in result.Take((int)Math.Round(Math.Sqrt(result.Count))))
                {
                    if (n % x == 0) { prime = false; break; }
                }
                if (prime) result.Add(n);
                n += 2;
            }

            return result;
        }

        public static IEnumerable<int> GetPrimesUnderN(int max) => GetPrimesUnderN((long)max).Select(x => (int)x);
        public static IEnumerable<long> GetPrimesUnderN(long max)
        {
            var n = 3;
            var result = new List<long> { 2 };
            var prime = true;
            while (n < max)
            {
                prime = true;
                foreach (var x in result.Take((int)Math.Round(Math.Sqrt(result.Count))))
                {
                    if (n % x == 0) { prime = false; break; }
                }
                if (prime) result.Add(n);
                n += 2;
            }
            return result;
        }

        public static IEnumerable<int> Factorize(this int n) => ((long)n).Factorize().Select(x => (int)x);
        public static IEnumerable<long> Factorize(this long n)
        {
            var i = 2;
            var result = new List<long>();
            while (n != 1)
            {
                if (i.IsPrime() && n % i == 0)
                {
                    n /= i;
                    result.Add(i);
                    i = 1;
                }
                i++;
            }

            return result;
        }

        public static List<int> GetPrimeFactors(this int n)
        {
            List<int> fattoriPrimi = new List<int> { 1 };

            // Controlla i fattori di 2
            while (n % 2 == 0)
            {
                if (!fattoriPrimi.Contains(2))
                {
                    fattoriPrimi.Add(2);
                }
                n /= 2;
            }

            // Controlla i fattori dispari da 3 in poi
            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                while (n % i == 0)
                {
                    if (!fattoriPrimi.Contains(i))
                    {
                        fattoriPrimi.Add(i);
                    }
                    n /= i;
                }
            }

            // Se n è un numero primo maggiore di 2
            if (n > 2)
            {
                fattoriPrimi.Add(n);
            }

            return fattoriPrimi;
        }
    }
}