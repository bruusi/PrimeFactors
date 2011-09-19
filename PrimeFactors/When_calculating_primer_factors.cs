using System.Collections.Generic;
using NBehave.Spec.NUnit;
using NUnit.Framework;

namespace PrimeFactors
{
    [TestFixture]
    public class When_calculating_primer_factors
    {
        [TestCase(1, new int[0])]
        [TestCase(2, new[] { 2 })]
        [TestCase(3, new[] { 3 })]
        [TestCase(4, new []{2, 2})]
        [TestCase(6, new []{2, 3})]
        [TestCase(8, new []{2, 2, 2})]
        [TestCase(9, new []{3, 3})]
        [TestCase(2*3*5*7*11*13, new []{2, 3, 5, 7, 11, 13})]
        [TestCase(int.MaxValue, new[] { int.MaxValue })]
        public void Should_factor(int number, int[] expected)
        {
            number.Primes().ShouldEqual(expected);
        }
    }
}