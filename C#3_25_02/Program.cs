using Core;
namespace C_3_25_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.OutputEncoding = System.Text.Encoding.Unicode;
            
            Matrix matrix = new Matrix(3, 3);

            
            matrix.InputMatrix();

            
            matrix.DisplayMatrix();

            
            Console.WriteLine($"Максимальний елемент матриці: {matrix.MaxElement()}");
            Console.WriteLine($"Мінімальний елемент матриці: {matrix.MinElement()}");
        }
    }
}
