using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProjectSolutions
{
    /*
    * A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
    * Find the largest palindrome made from the product of two 3-digit numbers.
    */
    class ProblemFour
    {
        public List<int> getProducts()
        {
            List<int> products = new List<int>();
            
            for(int i = 100; i < 999; i++)
            {
                for (int j = 100; j < 999; j++)
                {
                    products.Add(i * j);
                }
            }
            return products;
        }

        private bool isPalindrome(string myInt)
        {
            string one = "";
            string two = "";
            int half = (myInt.Length / 2);

            if(myInt.Length % 2 == 0)
            {
                one = myInt.Substring(0, half);
                two = reverseString(myInt.Substring(half, half));

                if (one == two)
                {
                    return true;
                }
            }

            return false;
        }

        public List<int> getPalindromes(List<int> products)
        {
            List<int> palindromes = new List<int>();
            
            foreach(int product in products)
            {
                if(isPalindrome(product.ToString()))
                {
                    palindromes.Add(product);
                }
            }

            return palindromes;
        }
        
        public int getAnswer()
        {
            List<int> p = getProducts();
            return getPalindromes(p).Max();
        }

        public static string reverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
