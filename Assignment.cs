using System;

namespace TaskScheduller
{
    /*
        1)Create a class Book with properties Title, Author, and Price.  
        Create an object of Book, assign values, and create a method to display the book details.
    */

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }

        public void BookInfo()
        {
            Console.WriteLine($"The Book Title is '{Title}' written by '{Author}' and goes for '{Price}' ");
        }


        static void Main(string[] args)
        {
            //1st Assignment 
            Console.WriteLine("=== First ASSIGNMENT ===");
            Book bookObj = new();

            bookObj.Title = "C# Object Oriented Programming(OOP)";
            bookObj.Author = "David Ohibor";
            bookObj.Price = 15000;

            bookObj.BookInfo();





            //2nd Assignment 
            Console.WriteLine("\n=== SECOND ASSIGNMENT ===");
            Vehicle vehicleObj = new();
            vehicleObj.Drive("Iyanu");

            Car carObj = new();
            carObj.Drive("Dave");

            Bike bikeObj = new();
            bikeObj.Drive("Eva");




            //3rd Assignment
            Console.WriteLine("\n=== THIRD ASSIGNMENT ===");
            TemperatureSensor sensor = new TemperatureSensor();
            sensor.Set(120);

            int currentTemp = sensor.Get();
            Console.WriteLine($"Current temperature is: {currentTemp}");



            //4th Assignment
            IShape circle = new Circle { Radius = 5 };
            Console.WriteLine($"Circle Area: {circle.CalculateArea()}");

            IShape rectangle = new Rectangle { Width = 4, Height = 6 };
            Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}");


        }
    }


    /*
    2.  Create a base class Vehicle with a method Drive().  
        Create two derived classes Car and Bike that override Drive() with specific behaviors.  
        Demonstrate polymorphism by calling Drive() on base class 
    */

    public class Vehicle
    {
        //public string Name = "John";
        public virtual void Drive(string name)
        {

            Console.WriteLine($"{name} will help us to know the different car type. This is Drive method in Vehicle class ");
        }
    }

    public class Car : Vehicle
    {
        public override void Drive(string name)
        {

            Console.WriteLine($"{name} will help us to know the different car typ. Drive method in child class Car ");
        }
    }

    public class Bike : Vehicle
    {
        public override void Drive(string name)
        {

            Console.WriteLine($"{name} will help us to know the different car type. drive method in child class Bike");
        }
    }

    /*
      3.  Create a class TemperatureSensor with a private field temperature.  
        Provide public methods to set and get the temperature, ensuring the temperature is within a valid 
        range (e.g., -50 to 150 Celsius).
    */

    public class TemperatureSensor
    {
        private double temperature;

        public void Set(int input)
        {
            if (input  input >= -50 && <= 150 )
            {
                temperature = input;
            }
        }

        public int Get()
        {
            return temperature;
        }

    }

    /*
        4. Define an interface IShape with a method CalculateArea().  
        Implement Circle and Rectangle classes that implement IShape.  
        Calculate and display their areas.
    */
    public interface IShape
    {
        double CalculateArea();
    }
    public class Circle : IShape
    {
        public double Radius { get; set; }
        public double CalculateArea() => Math.PI * Radius * Radius;

    }

    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double CalculateArea() => Width * Height;

    }
}
