using Core;
namespace C_3_25_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Введіть елементи оригінального масиву через пробіл:");
            int[] originalArray = ReadIntArrayFromConsole();

            Console.WriteLine("Введіть елементи масиву для фільтрації через пробіл:");
            int[] filterArray = ReadIntArrayFromConsole();

            int[] filteredArray = ArrayFilter.FilterArray(originalArray, filterArray);

            Console.WriteLine("Результат фільтрації:");
            foreach (int num in filteredArray)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        static int[] ReadIntArrayFromConsole()
        {
            string input = Console.ReadLine();
            string[] strArray = input.Split(' ');
            int[] intArray = new int[strArray.Length];

            for (int i = 0; i < strArray.Length; i++)
            {
                intArray[i] = int.Parse(strArray[i]);
            }

            return intArray;
        }
    }
}
