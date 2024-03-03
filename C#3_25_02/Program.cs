using Core;
namespace CSharp3_25_02;

public class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
        bool ascending = true; // Зростання

        Console.WriteLine("До сортування:");
        PrintArray(arr);

        SortingHelper.BubbleSort(arr, ascending);

        Console.WriteLine("\nПісля сортування:");
        PrintArray(arr);
    }

    static void PrintArray(int[] arr)
    {
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}
