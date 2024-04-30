namespace ConsoleAppForUnitTest {
    public class Degree {
        public static int Power(int number, int degree) {
            if (degree == 0)
                return 0;

            for (int i = 1, startNumber = number; i < degree; i++)
                number *= startNumber;
            return number;
        }
    }
}
