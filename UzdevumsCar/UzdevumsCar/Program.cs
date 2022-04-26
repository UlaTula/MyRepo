// See https://aka.ms/new-console-template for more information

using UzdevumsCar;

Car firstCar = new Car();

Console.Write("Pease enter car Brand: ");
firstCar.Brand = Console.ReadLine();

Console.Write("Please write car Registration Number: ");
firstCar.RegNumber = Console.ReadLine();

Speed firstPoint = new Speed();
Console.Write("Please add first point of speed: ");
firstPoint.PointSpeed = Console.ReadLine();
int firsPointSpeed = int.Parse(firstPoint.PointSpeed);


Speed secondPoint = new Speed();
Console.Write("Please add second point of speed: ");
secondPoint.PointSpeed = Console.ReadLine();
int secondPointSpeed = int.Parse(secondPoint.PointSpeed);

bool isLarger = firsPointSpeed > secondPointSpeed;

bool isSmaller = firsPointSpeed < secondPointSpeed;


Console.WriteLine($"Car {firstCar.Brand} {firstCar.RegNumber} is started driving: {isLarger} ");
Console.WriteLine($"Car {firstCar.Brand} {firstCar.RegNumber} is ending driving: {isSmaller}");


bool isStopped = secondPointSpeed <= 0;

Console.WriteLine($"Car {firstCar.Brand} {firstCar.RegNumber} is stopped: {isStopped}");

firstCar.BeepBeep();