namespace Examples
{
    internal class Program
    {
        static void Main()
        {
            string raspuns;
            int raspuns_numar_intreg;

            Console.WriteLine("Gandeste-te la un numar mai mic decat 50 dar mai mare decat 10.");
            Console.Write("Care este acel numar: ");

            raspuns = Console.ReadLine();
            bool verificare = int.TryParse(raspuns, out raspuns_numar_intreg);
            if (verificare)
            {
                if (raspuns_numar_intreg < 10)
                {
                    Console.WriteLine("Numarul este prea mic.");
                }
                else if (raspuns_numar_intreg > 50)
                {
                    Console.WriteLine("Numarul este prea mare.");
                }
                else
                {
                    Console.WriteLine("Raspuns valid.");
                }
            }
            else
            {
                Console.WriteLine("fuck of coaie");
            }

        }
    }
}