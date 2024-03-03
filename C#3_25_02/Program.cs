using Core;
namespace C_3_25_02;
    internal class Program
    {
    static void Main(string[] args)
    {
        int start = 1;
        int end = 5;

        int product = Calculator.GetProductInRange(start, end);
        Console.WriteLine($"The product of numbers from {start} to {end} is: {product}");
    }
}
