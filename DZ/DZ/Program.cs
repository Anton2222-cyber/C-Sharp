using System;

namespace DZ
{
    partial class Car
    {
        string name;
        string color;
        static string material;
        static string country;
        float cost;//$
        public string GetName()
        {
            return name;
        }
        public string GetColor()
        {
            return color;
        }
        public string GetMaterial()
        {
            return material;
        }
        public string GetCountry()
        {
            return country;
        }
        public float GetCost()
        {
            return cost;
        }
        static Car()
        {
            material = "Metallic";
            country = "German";
        }
        public Car(string name, string color, float cost)
        {
            this.name = name;
            this.color = color;
            this.cost = cost;
        }
        public Car(string name, float cost)
        {
            this.name = name;
            this.color = "black";
            this.cost = cost;
        }
        public static void SetMaterialAndContry(string _material, string _country)
        {
            material = _material;
            country = _country;
        }
        public Car()
        {
            this.name = "Mercedes-Benz G-class";
            this.color = "black";
            this.cost = 131750;
        }
        public void SetCar(string name, string color, float cost)
        {
            this.name = name;
            this.color = color;
            this.cost = cost;
        }
        public void Print()
        {

            Console.WriteLine("Назва машини ->" + this.name);
            Console.WriteLine("Матеріал машини ->" + Car.material);
            Console.WriteLine("Країна ->" + Car.country);
            Console.WriteLine("Колір ->" + this.color);
            Console.WriteLine("Ціна ->" + this.cost + "$");
        }
        static public void PaintTheCar(ref Car car, string newcolor)
        {
            car.color = newcolor;
        }

    }
    class Program
    {
        

        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.UTF8;
            Car.SetMaterialAndContry("metallic","German");
            Car car = new Car();

            Console.WriteLine( "За "+Car.CalculateTimeForTheDistance(100, 1000)+" год приїде 1000км"); 
            car.SetCar("Mersedes-Benz", "red", 1234);
            Car.PaintTheCar(ref car, "yellow");
            car.Print();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("--------------------------------------------");
            Car[] arr = new Car[5];
            for(int i=0; i<arr.Length;i++)
            {
                arr[i] = new Car();
            }
            arr[0].SetCar("Mercedes-AMG GT", "grey", 118600);
            arr[1].SetCar("Mercedes-Benz GLE", "white", 42500);
            arr[2].SetCar("Mercedes-Benz S 500", "black", 37699);
            arr[3].SetCar("Mercedes-Benz EQB", "brown", 51854);
            arr[4].SetCar("Mercedes-Benz E 220", "light-grey", 12100);
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].Print();
                Console.WriteLine("--------------------------------------------");

            }
        }
    }
}