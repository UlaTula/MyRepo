// Task 1 - user name

Console.Write("Please enter your name: ");
string userName = Console.ReadLine();

Console.WriteLine("Hello " + userName);
Console.WriteLine();

//Task 2 - user age

Console.Write("Please enter your age: ");

string userAgeString = Console.ReadLine();
int userAge = int.Parse(userAgeString);

userAge++;

bool isLarger = userAge >= 18;


string message = $"Next year your age will be {userAge}, are you adult - {isLarger}";
Console.WriteLine(message);
Console.WriteLine();

// Task 9 - interpolation
userAge--;
string messageFull = $"Hello {userName}, your age is {userAge}";
Console.WriteLine(messageFull);
Console.WriteLine();

// user enter two numbers

Console.Write("Please enter integer first number: ");
string firstNumberString = Console.ReadLine();
int firstNumber = int.Parse(firstNumberString);

Console.Write("Please enter integer second number: ");
string secondNumberString = Console.ReadLine();
int secondNumber = int.Parse(secondNumberString);
Console.WriteLine();

// Task 3 - larger number
int largestNumber = Math.Max(firstNumber, secondNumber);

Console.WriteLine("Largest number: " + largestNumber);

// Task 4 - smaller number
int smallerNumber = Math.Min(firstNumber, secondNumber);

Console.WriteLine("Smallest number: " + smallerNumber);

// Task 5 - division number
int divisionLeft = firstNumber % secondNumber;

Console.WriteLine("Left: " + divisionLeft);

// Task 6 - even or odd numbers

int divisionFirstNumber = firstNumber % 2;
bool isPairFirstNumber = divisionFirstNumber == 0;

int divisionSecondNumber = secondNumber % 2;
bool isPairSecondNumber = divisionSecondNumber != 0;

Console.WriteLine("Is first number is even: " + isPairFirstNumber);
Console.WriteLine("Is second number is odd: " + isPairSecondNumber);
Console.WriteLine();

// Task 7 - square area

Console.Write("Please enter first side (might not to be as integer number): ");
string firstSideString = Console.ReadLine();
double firstSide = double.Parse(firstSideString);

Console.Write("Please enter second side (might not to be as integer number): ");
string secondSideString = Console.ReadLine();
double secondSide = double.Parse(secondSideString);

double squareArea = firstSide * secondSide;
double rounded = Math.Round(squareArea, 2);

Console.WriteLine("Square are (rounded): " + rounded);
Console.WriteLine();

// Task 8 - triangular area

Console.Write("Please enter integer first and second side of right triangles value: ");
string firstTriangularSideString = Console.ReadLine();
double firstTriangularSide = int.Parse(firstTriangularSideString);

double triangularArea = (firstTriangularSide * firstTriangularSide) / 2;

Console.WriteLine(triangularArea);


