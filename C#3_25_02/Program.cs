using Core;
namespace C_3_25_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.Unicode;
            
            Employee employee = ReadEmployeeInfo();

           
            employee.DisplayEmployeeInfo();

          
            Console.WriteLine("ПІБ співробітника: " + employee.GetFullName());
            Console.WriteLine("Дата народження співробітника: " + employee.GetBirthDate().ToShortDateString());
            Console.WriteLine("Контактний телефон співробітника: " + employee.GetPhoneNumber());
            Console.WriteLine("Робочий email співробітника: " + employee.GetEmail());
            Console.WriteLine("Посада співробітника: " + employee.GetPosition());
            Console.WriteLine("Опис службових обов'язків співробітника: " + employee.GetJobDescription());
        }

        public static Employee ReadEmployeeInfo()
        {
            Console.WriteLine("Введіть ПІБ співробітника:");
            string fullName = Console.ReadLine();

            Console.WriteLine("Введіть дату народження співробітника (формат: YYYY-MM-DD):");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Введіть контактний телефон співробітника:");
            string phoneNumber = Console.ReadLine();

            Console.WriteLine("Введіть робочий email співробітника:");
            string email = Console.ReadLine();

            Console.WriteLine("Введіть посаду співробітника:");
            string position = Console.ReadLine();

            Console.WriteLine("Введіть опис службових обов'язків співробітника:");
            string jobDescription = Console.ReadLine();

            return new Employee(fullName, birthDate, phoneNumber, email, position, jobDescription);
        }
    }
}
