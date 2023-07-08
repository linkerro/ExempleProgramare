namespace FunctionExample
{
    internal class Program
    {
        /*
         * tema: modificati functia Factorial
         * in asa fel incat sa nu crape cand este apelata
         * cu numere mai mici decat 1 (e.g. 0, -1, -42, etc.)
         */

        static void Main(string[] args)
        {
            int fact = Factorial(-100);
            Console.WriteLine(fact);

        }

        static int Factorial(int i)
        {
            if (i == 1)
            {
                return 1;
            }

            int result = i * Factorial(i - 1);
            return result;
        }
    }
}