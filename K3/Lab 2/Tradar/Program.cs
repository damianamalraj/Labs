using System;
using System.Diagnostics;
using System.Threading;

class Car
{
  public string Name { get; }
  public double Position { get; private set; }
  private int Speed = 120;
  private Stopwatch stopwatch = new Stopwatch();
  private Random random = new Random();

  public Car(string name)
  {
    Name = name;
    Position = 0;
  }

  public void Drive()
  {
    stopwatch.Start();

    while (Position < 10)
    {
      SimulateConstantSpeed();
      HandleRandomEvent();
      PrintStatus();
    }

    Console.WriteLine($"{Name} has completed the race!");
  }

  private void SimulateConstantSpeed()
  {
    Thread.Sleep(10);
    Position += Speed / 3600.0;
  }

  private void HandleRandomEvent()
  {
    if (stopwatch.ElapsedMilliseconds % 30 == 0)
    {
      int probability = random.Next(1, 51);

      if (probability <= 1)
      {
        Console.WriteLine($"{Name} is out of gas and stops for 30 seconds.");
        Thread.Sleep(3000);
      }
      else if (probability <= 2)
      {
        Console.WriteLine($"{Name} has a flat tire and stops for 20 seconds.");
        Thread.Sleep(2000);
      }
      else if (probability <= 5)
      {
        Console.WriteLine($"{Name} has a bird on the windshield and stops for 10 seconds.");
        Thread.Sleep(1000);
      }
      else if (probability <= 10)
      {
        Console.WriteLine($"{Name} has engine trouble and decreases speed by 1 km/h.");
        Speed -= 1;
      }
    }
  }

  private void PrintStatus()
  {
    Console.WriteLine($"{Name} is at position {Position:F2} km.");
  }
}

class Program
{
  static void Main()
  {
    Car car1 = new Car("Car A");
    Car car2 = new Car("Car B");

    Thread thread1 = new Thread(car1.Drive);
    Thread thread2 = new Thread(car2.Drive);

    thread1.Start();
    thread2.Start();

    thread1.Join();
    thread2.Join();

    Console.WriteLine("The race is over!");
  }
}
