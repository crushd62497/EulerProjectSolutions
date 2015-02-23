using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProjectSolutions
{
    /*
     * The prime factors of 13195 are 5, 7, 13 and 29.
     * 
     * What is the largest prime factor of the number 600851475143 ?
     * */
    class ProblemThree
    {
        private int answer;
        private Int64 maxVal = 600851475143;
        
        public ProblemThree()
        {

        }

        public List<Int64> getFactorsOfMaxVal()
        {
            List<Int64> factors = new List<Int64>();
            Int64 start = (Int64)Math.Sqrt(maxVal);
            factors.Add(start);
            for(Int64 i = 3; i < start; i++)
            {
                if(maxVal % i == 0)
                {
                    factors.Add(i);
                }
            }

            return factors;
        }

        public List<Int64> getPrimeNumbers(List<Int64> factors) 
        {
            List<Int64> primeVals = new List<Int64>();
            foreach(Int64 factor in factors)
            {
                if (checkPrime(factor, primeVals, maxVal))
                {
                    primeVals.Add(factor);
                }
            }

            return primeVals;
        }

        private static bool checkPrime(Int64 n, List<Int64> primeVals, Int64 maxVal)
        {
            foreach (Int64 prime in primeVals)
            {
                if (prime * prime <= n && n % prime == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public Int64 getAnswer()
        {
            List<Int64> primes = getPrimeNumbers(getFactorsOfMaxVal());
            foreach (Int64 prime in primes)
            {
                System.Console.WriteLine(prime);
            }
                return primes.Max();
        }
    }
}
