using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Journal
    {
        private string name;
        private int yearFounded;
        private string description;
        private string contactPhone;
        private string email;

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void SetYearFounded(int yearFounded)
        {
            this.yearFounded = yearFounded;
        }

        public int GetYearFounded()
        {
            return yearFounded;
        }

        public void SetDescription(string description)
        {
            this.description = description;
        }

        public string GetDescription()
        {
            return description;
        }

        public void SetContactPhone(string contactPhone)
        {
            this.contactPhone = contactPhone;
        }

        public string GetContactPhone()
        {
            return contactPhone;
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }

        public string GetEmail()
        {
            return email;
        }

        public void InputData()
        {
            Console.WriteLine("Введіть назву журналу:");
            name = Console.ReadLine();

            Console.WriteLine("Введіть рік заснування:");
            yearFounded = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть опис журналу:");
            description = Console.ReadLine();

            Console.WriteLine("Введіть контактний телефон:");
            contactPhone = Console.ReadLine();

            Console.WriteLine("Введіть email:");
            email = Console.ReadLine();
        }

        public void DisplayData()
        {
            Console.WriteLine($"Назва журналу: {name}");
            Console.WriteLine($"Рік заснування: {yearFounded}");
            Console.WriteLine($"Опис журналу: {description}");
            Console.WriteLine($"Контактний телефон: {contactPhone}");
            Console.WriteLine($"Email: {email}");
        }
    }
}
