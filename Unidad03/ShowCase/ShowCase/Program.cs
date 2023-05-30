using UtilityLibraries;

class Program
{
    public static void Main()
    {
        int row = 0;
        do
        {
            if (row == 0 || row >= 10)
                ResetConsole();

            string? input = Console.ReadLine();

            if (string.IsNullOrEmpty(input)) break;

            Console.WriteLine($"Entrada: {input}");
            Console.WriteLine("¿Comienza con Mayusculas? " +
                 $"{(input.StartsWithUpper() ? "Si" : "No")}");
            Console.WriteLine();
            row += 4;
        } while (true);
        return;

        // Declare a ResetConsole local method
        void ResetConsole()
        {
            if (row > 0)
            {
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            Console.Clear();
            Console.WriteLine($"{Environment.NewLine}Press <Enter> only to exit; otherwise, enter a string and press <Enter>:{Environment.NewLine}");
            row = 3;
        }
    }
}