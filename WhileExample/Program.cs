namespace WhileExample
{
    //tema: faceti factorial de n
    // adica
    // cititi numarul n de la tastatura
    // 
    // 1*2*3*4*5*..*n
    //
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