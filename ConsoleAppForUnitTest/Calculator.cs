using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForUnitTest {
    internal class Calculator {
        public int Sum(int firstSummand, int secondSummand) {
            return firstSummand + secondSummand;
        }

        public int Subtract(int diminutive, int subtrahend) {
            return diminutive - subtrahend;
        }

        public int Multiply(int firstMultiplier, int secondMultiplier) { 
            return firstMultiplier * secondMultiplier;
        }

        public int Divide(int divisible, int divider) {
            return divisible / divider;
        }
    }
}
