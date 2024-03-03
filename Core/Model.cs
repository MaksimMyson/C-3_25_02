using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Store
    {
        private string name;
        private string address;
        private string profileDescription;
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

        public void SetAddress(string address)
        {
            this.address = address;
        }

        public string GetAddress()
        {
            return address;
        }

        public void SetProfileDescription(string profileDescription)
        {
            this.profileDescription = profileDescription;
        }

        public string GetProfileDescription()
        {
            return profileDescription;
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
            Console.WriteLine("Введіть назву магазину:");
            name = Console.ReadLine();

            Console.WriteLine("Введіть адресу магазину:");
            address = Console.ReadLine();

            Console.WriteLine("Введіть опис профілю магазину:");
            profileDescription = Console.ReadLine();

            Console.WriteLine("Введіть контактний телефон магазину:");
            contactPhone = Console.ReadLine();

            Console.WriteLine("Введіть email магазину:");
            email = Console.ReadLine();
        }

        public void DisplayData()
        {
            Console.WriteLine($"Назва магазину: {name}");
            Console.WriteLine($"Адреса: {address}");
            Console.WriteLine($"Опис профілю магазину: {profileDescription}");
            Console.WriteLine($"Контактний телефон: {contactPhone}");
            Console.WriteLine($"Email: {email}");
        }
    }
}
