using Core;
namespace C_3_25_02
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Введіть число для перевірки, чи є воно паліндромом:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                bool isPalindrome = PalindromeChecker.IsPalindrome(number);

                if (isPalindrome)
                {
                    Console.WriteLine($"{number} є паліндромом.");
                }
                else
                {
                    Console.WriteLine($"{number} не є паліндромом.");
                }
            }
            else
            {
                Console.WriteLine("Введено некоректне число.");
            }
        }
    }
}
