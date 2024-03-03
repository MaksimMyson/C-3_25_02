using Core;

namespace C_3_25_02
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode; 

            Console.WriteLine("Введіть довжину сторони квадрата:");
            int sideLength = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть символ для відображення квадрата:");
            char symbol = Console.ReadLine()[0];

            SquareDrawer.DrawSquare(sideLength, symbol);
        }
    }
}
