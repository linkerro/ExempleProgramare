using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTests2
{
    public class ArrayExamples
    {
        public void Array1(Action<int, int> action)
        {
            int[] numere = new int[10];

            int i = 0;

            while (i < numere.Length)
            {
                numere[i] = numere.Length - i;
                i += 1;
            }

            i = 0;

            for (int j = 0; j < numere.Length; j += 1)
            {
                action(j, numere[j]);
            }
        }

        public string[] ConcatenareNume(string[] prenume, string[] nume)
        {
            string[] numeComplete = new string[prenume.Length];

            for (int i = 0; i < prenume.Length; i += 1)
            {
                numeComplete[i] = prenume[i] + " " + nume[i];
            }

            return numeComplete;
        }
    }
}
