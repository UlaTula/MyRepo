// See https://aka.ms/new-console-template for more information



using UzdevumsPrece;


Prece prece = new Prece(23,34,45);

Console.WriteLine($"Please enter weight for product with sizes {prece.Lenght} x {prece.Width} x {prece.Height}");

prece.Weight = Console.ReadLine();

Console.WriteLine($"Weight for product {prece.Lenght} x {prece.Width} x {prece.Height} is {prece.Weight} kg");