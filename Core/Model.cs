using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Core
{
    public class Employee
    {
        private string fullName;
        private DateTime birthDate;
        private string phoneNumber;
        private string email;
        private string position;
        private string jobDescription;

        public Employee(string fullName, DateTime birthDate, string phoneNumber, string email, string position, string jobDescription)
        {
            this.fullName = fullName;
            this.birthDate = birthDate;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.position = position;
            this.jobDescription = jobDescription;
        }

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine("ПІБ: " + fullName);
            Console.WriteLine("Дата народження: " + birthDate.ToShortDateString());
            Console.WriteLine("Контактний телефон: " + phoneNumber);
            Console.WriteLine("Робочий email: " + email);
            Console.WriteLine("Посада: " + position);
            Console.WriteLine("Опис службових обов'язків: " + jobDescription);
        }

        public string GetFullName()
        {
            return fullName;
        }

        public DateTime GetBirthDate()
        {
            return birthDate;
        }

        public string GetPhoneNumber()
        {
            return phoneNumber;
        }

        public string GetEmail()
        {
            return email;
        }

        public string GetPosition()
        {
            return position;
        }

        public string GetJobDescription()
        {
            return jobDescription;
        }
    }
}