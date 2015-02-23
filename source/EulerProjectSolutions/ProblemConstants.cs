using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProjectSolutions
{
    class ProblemConstants
    {
        private string problemOneDescription = "If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.";

        private string description;

        public ProblemConstants(int problemNumber)
        {
            switch (problemNumber)
            {
                case 1:
                    description = problemOneDescription;
                    break;
                default:
                    description = "You did not enter a valid problem";
                    break;
            }
        }
    }
}
