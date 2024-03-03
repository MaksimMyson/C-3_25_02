using Core;
namespace C_3_25_02
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Введіть число для перевірки:");
            int number = Convert.ToInt32(Console.ReadLine());

            bool isFibonacci = NumberHelper.IsFibonacci(number);
            bool isPrime = NumberHelper.IsPrime(number);

            Console.WriteLine($"Число {number} є числом Фібоначчі: {isFibonacci}");
            Console.WriteLine($"Число {number} є простим числом: {isPrime}");
        }
    }
}
