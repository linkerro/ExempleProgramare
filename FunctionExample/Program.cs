namespace FunctionExample
{
    internal class Fofoloanca
    {
        /*
         * tema: modificati functia Factorial
         * in asa fel incat sa nu crape cand este apelata
         * cu numere mai mici decat 1 (e.g. 0, -1, -42, etc.)
         */

        static int Factorial(int i)
        {
            if (i == 1)
            {
                //return 1;
            }
            if (i < 1)
            {
                throw new ArgumentException($"paramater {nameof(i)} must be greater or equal to 1.");
            }

            int result = i * Factorial(i - 1);
            return result;
        }

        static void Main()
        {
            int variabila_cunascuta_ca_rezultat = Factorial(-100);
            Console.WriteLine(variabila_cunascuta_ca_rezultat);
        }
    }
}