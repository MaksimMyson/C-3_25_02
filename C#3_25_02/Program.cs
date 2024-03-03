using Core;

namespace C_3_25_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Website website = new Website();

            Console.WriteLine("Введіть дані про веб-сайт:");
            website.InputData();

            Console.WriteLine("\nІнформація про веб-сайт:");
            website.DisplayData();
        }
    }
}
