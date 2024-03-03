using Core;

namespace C_3_25_02
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;  
            
            Plane plane = ReadPlaneInfo();

            
            plane.DisplayPlaneInfo();
        }

        public static Plane ReadPlaneInfo()
        {
            Console.WriteLine("Введіть назву літака:");
            string planeName = Console.ReadLine();

            Console.WriteLine("Введіть виробника:");
            string manufacturer = Console.ReadLine();

            Console.WriteLine("Введіть рік випуску:");
            int yearOfProduction = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть тип літака:");
            string planeType = Console.ReadLine();

            return new Plane(planeName, manufacturer, yearOfProduction, planeType);
        }
    }
}
