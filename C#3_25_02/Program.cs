using Core;

namespace C_3_25_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Journal journal = new Journal();

            Console.WriteLine("Введіть дані про журнал:");
            journal.InputData();

            Console.WriteLine("\nІнформація про журнал:");
            journal.DisplayData();
        }
    }
}
