
using System.Globalization;
using UzdevumsPersona;

Persona person = new Persona();

Console.Write("Please enter name: ");
person.Name = Console.ReadLine();

Console.Write("Please enter surname: ");
person.Surname = Console.ReadLine();

Console.Write("Please enter date of birth usinf format dd.mm.yyyy: ");
person.BirhDate = DateTime.ParseExact(Console.ReadLine(), "dd.mm.yyyy", CultureInfo.InvariantCulture);
string format = "dd.mm.yyyy";
DateTime now = DateTime.Now;
int n = int.Parse(person.BirhDate.ToString("yyyy"));
int yearsOld = now.Year - n;

Console.Write("Please enter hobby: ");
person.Hobby = Console.ReadLine();

Console.Write("Please enter gender (0 - male and 1 - female): ");
string genderString = Console.ReadLine();
int genderNumber = int.Parse(genderString);
int divGender = genderNumber % 2;
person.IsMale = divGender == 0;


Console.WriteLine($"Hello my name is {person.Name} {person.Surname} and I am {yearsOld}");
