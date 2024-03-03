using Core;

namespace C_3_25_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Store store = new Store();

            Console.WriteLine("Введіть дані про магазин:");
            store.InputData();

            Console.WriteLine("\nІнформація про магазин:");
            store.DisplayData();
        }
    }
}
