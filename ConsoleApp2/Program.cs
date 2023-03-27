using System;

public class Car
{
    private string Name;
    private double MaxSpeed;

    public Car(string name, double MaxSpeed)
    {
        this.Name = name;
        this.MaxSpeed = MaxSpeed;
    }

    public void DisplayProperties()
    {
        Console.WriteLine($"Автомобиль: {Name}, Максимальная скорость: {MaxSpeed} km/h");
    }

    public string GetName()
    {
        return Name;
    }

    public double GetMaxSpeed()
    {
        return MaxSpeed;
    }
}

public class RacingGame
{
    static void Main()
    {
        Car car1 = new Car("Bmw", 350);
        Car car2 = new Car("Mercedes", 320);
        Car car3 = new Car("Audi", 290);
        Car car4 = new Car("Ford", 310);

        Console.WriteLine("Гонка начинается");
        Console.WriteLine("Участники:");

        car1.DisplayProperties();
        car2.DisplayProperties();
        car3.DisplayProperties();
        car4.DisplayProperties();

        Console.WriteLine("\nГонка началась");

        Car winner = car1;

        if (car2.GetMaxSpeed() > winner.GetMaxSpeed())
            winner = car2;
        if (car3.GetMaxSpeed() > winner.GetMaxSpeed())
            winner = car3;
        if (car4.GetMaxSpeed() > winner.GetMaxSpeed())
            winner = car4;

        Console.WriteLine($"Победитель {winner.GetName()} с максимальной скоростью {winner.GetMaxSpeed()} км/ч");
    }
}
