using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProjectSolutions
{    
    public class ProblemOne
    {
        private int maxNumber;
        private int answer;

        public ProblemOne(int maxNumber)
        {
            this.maxNumber = maxNumber;
            answer = this.addNumbers(this.getDivisibleNumbers(this.getNaturalNumbers()));
        }

        private int addNumbers(List<int> numbers)
        {
            int sum = 0;
            foreach(int value in numbers){
                sum += value;
            }
            return sum;
        }

        private List<int> getNaturalNumbers()
        {
            List<int> naturalNumbers = new List<int>();
            for (int i = 0; i < this.maxNumber; i++)
            {
                naturalNumbers.Add(i);
            }

            return naturalNumbers;
        }

        //get all of the numbers divisible by 3 or 5
        private List<int> getDivisibleNumbers(List<int> naturalNumbers)
        {
            List<int> divisibleNumbers = new List<int>();
            foreach(int number in naturalNumbers)
            {
                if (number % 3 == 0 || number % 5 == 0)
                {
                    divisibleNumbers.Add(number);
                }
            }

            return divisibleNumbers;
        }

        public int getAnswer()
        {
            return this.answer;
        }

    }
}
