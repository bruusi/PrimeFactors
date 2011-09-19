using System;
using System.Collections.Generic;

namespace PrimeFactors
{
    public static class PrimeFactors
    {
        public static IEnumerable<int> Primes(this int number)
        {
            var primes = new List<int>();
            for (var divider = 2; divider <= Math.Sqrt(number);divider++ )
                for (; number % divider == 0; number /= divider)
                    primes.Add(divider);
            if (number > 1)
                primes.Add(number);
            return primes;
        }
    }
}