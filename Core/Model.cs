using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Plane
    {
        private string planeName;
        private string manufacturer;
        private int yearOfProduction;
        private string planeType;

        // Конструктор з введенням даних
        public Plane(string planeName, string manufacturer, int yearOfProduction, string planeType)
        {
            this.planeName = planeName;
            this.manufacturer = manufacturer;
            this.yearOfProduction = yearOfProduction;
            this.planeType = planeType;
        }

        // Метод для виведення даних
        public void DisplayPlaneInfo()
        {
            Console.WriteLine("Назва літака: " + planeName);
            Console.WriteLine("Виробник: " + manufacturer);
            Console.WriteLine("Рік випуску: " + yearOfProduction);
            Console.WriteLine("Тип літака: " + planeType);
        }

        // Методи доступу до окремих полів класу
        public void SetPlaneName(string planeName)
        {
            this.planeName = planeName;
        }

        public string GetPlaneName()
        {
            return planeName;
        }

        public void SetManufacturer(string manufacturer)
        {
            this.manufacturer = manufacturer;
        }

        public string GetManufacturer()
        {
            return manufacturer;
        }

        public void SetYearOfProduction(int yearOfProduction)
        {
            this.yearOfProduction = yearOfProduction;
        }

        public int GetYearOfProduction()
        {
            return yearOfProduction;
        }

        public void SetPlaneType(string planeType)
        {
            this.planeType = planeType;
        }

        public string GetPlaneType()
        {
            return planeType;
        }
    }
}
