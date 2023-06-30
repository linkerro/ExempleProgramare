namespace WhileExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            Console.WriteLine("Ghici la ce numar m-am gandit");
            int numarGandit = 10;
            while (x != numarGandit) 
            {
                string inputUtilizator = Console.ReadLine();
                bool parsareaAFostCorecta = int.TryParse(inputUtilizator, out x);
                if (parsareaAFostCorecta)
                {
                    if (x > numarGandit)
                    {
                        Console.WriteLine("Numarul tau este prea mare! Mai incearca!");
                    }
                    else if (x < numarGandit)
                    {
                        Console.WriteLine("Numarul tau este prea mic! Mai incearca!");
                    }
                    else
                    {
                        Console.WriteLine("NAILED IT BRAH");
                    }
                }
                else
                {
                    Console.WriteLine("Numar, cwae!");
                }
            }
        }
    }
}