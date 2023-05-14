using System;

// Abstract class representing a vehicle
public abstract class Vehicle
{
    protected string _make;   // Store the make of the vehicle
    protected string _model;  // Store the model of the vehicle
    protected int _year;      // Store the year of the vehicle

    public Vehicle(string make, string model, int year)
    {
        _make = make;
        _model = model;
        _year = year;
    }

    public abstract void Start(); // Abstract method for starting the vehicle

    public abstract void Stop();  // Abstract method for stopping the vehicle

    public void DisplayDetails()
    {
        Console.WriteLine("Vehicle Details:");
        Console.WriteLine("Make: " + _make);
        Console.WriteLine("Model: " + _model);
        Console.WriteLine("Year: " + _year);
    }
}

// Derived class representing a car
public class Car : Vehicle
{
    private int _mileage; // Store the mileage of the car

    public Car(string make, string model, int year) : base(make, model, year)
    {
        _mileage = 0; // Initialize the mileage to 0
    }

    public int GetMileage()
    {
        return _mileage; // Return the mileage of the car
    }

    public void Drive(int distance)
    {
        if (distance > 0)
        {
            _mileage += distance; // Increment the mileage by the given distance
            Console.WriteLine("Car is being driven. Mileage increased by: " + distance);
        }
        else
        {
            Console.WriteLine("Invalid distance. Car cannot be driven.");
        }
    }

    public override void Start()
    {
        Console.WriteLine("Car engine started.");
    }

    public override void Stop()
    {
        Console.WriteLine("Car engine stopped.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car("Toyota", "Camry", 2020); // Create a new instance of the Car class

        myCar.DisplayDetails(); // Display the details of the car

        myCar.Start(); // Start the car's engine

        myCar.Drive(100); // Drive the car by increasing its mileage

        Console.WriteLine("Car Mileage: " + myCar.GetMileage()); // Display the updated mileage

        myCar.Stop(); // Stop the car's engine
    }
}
