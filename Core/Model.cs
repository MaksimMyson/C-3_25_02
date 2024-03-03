using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Website
    {
        private string name;
        private string url;
        private string description;
        private string ipAddress;

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void SetUrl(string url)
        {
            this.url = url;
        }

        public string GetUrl()
        {
            return url;
        }

        public void SetDescription(string description)
        {
            this.description = description;
        }

        public string GetDescription()
        {
            return description;
        }

        public void SetIpAddress(string ipAddress)
        {
            this.ipAddress = ipAddress;
        }

        public string GetIpAddress()
        {
            return ipAddress;
        }

        public void InputData()
        {
            Console.WriteLine("Введіть назву сайту:");
            name = Console.ReadLine();

            Console.WriteLine("Введіть URL сайту:");
            url = Console.ReadLine();

            Console.WriteLine("Введіть опис сайту:");
            description = Console.ReadLine();

            Console.WriteLine("Введіть IP-адресу сайту:");
            ipAddress = Console.ReadLine();
        }

        public void DisplayData()
        {
            Console.WriteLine($"Назва сайту: {name}");
            Console.WriteLine($"URL сайту: {url}");
            Console.WriteLine($"Опис сайту: {description}");
            Console.WriteLine($"IP-адреса сайту: {ipAddress}");
        }
    }
}
