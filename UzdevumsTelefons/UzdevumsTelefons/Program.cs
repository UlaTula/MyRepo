// See https://aka.ms/new-console-template for more information

using UzdevumsTelefons;

Phone firstPhone = new Phone();

Console.WriteLine("Please enter phone Brand: ");
firstPhone.Brand = Console.ReadLine();

Console.WriteLine("Please enter phone Model: ");
firstPhone.Model = Console.ReadLine();

firstPhone.Call();
firstPhone.Sms();