// See https://aka.ms/new-console-template for more information

string myGreeting = "Lorem ipsum dolor sit amet ";
int age = 40;
double money = 1234.56;
char favoriteSymbol = '*';
bool isMale = true;
var kuKu = 123; //please do not use for learning, but var choose correct data type


Console.WriteLine(myGreeting);
Console.WriteLine(age);
Console.WriteLine(money);
Console.WriteLine(favoriteSymbol);
Console.WriteLine(isMale);
Console.WriteLine(kuKu);

Console.WriteLine();
Console.WriteLine("-------------------------");
Console.WriteLine();

int a = 5;
double b = 2;
int c = 2;

int sum = a + c;
int deff = a - c;
int multiplication = a * c;
int divided = a / c;
double divided2 = (double)a / c;
int divisionLeft = a % c;

Console.WriteLine(sum);
Console.WriteLine(deff);
Console.WriteLine(multiplication);
Console.WriteLine(divided);
Console.WriteLine(divided2);
Console.WriteLine(divisionLeft);

a++;
b--;

Console.WriteLine(a);
Console.WriteLine(b);

Console.WriteLine();
Console.WriteLine("-------------------------");
Console.WriteLine();

int num1 = 10;
int num2 = 10;

bool isEqual = num1 == num2; // one more variant, but not used: bool isEqual = (num1 == num2);
bool isNotEqual = num2 != num1;
bool isLarger = num2 >= num1;
bool isSmaller = num2 <= num1;
bool isLargerEqual = num2 > num1;
bool isSmallerEqual = num2 < num1;

Console.WriteLine(isEqual);
Console.WriteLine(isNotEqual);
Console.WriteLine(isLarger);
Console.WriteLine(isSmaller);
Console.WriteLine(isLargerEqual);
Console.WriteLine(isSmallerEqual);


Console.WriteLine();
Console.WriteLine("-------------------------");
Console.WriteLine();

bool isTrue = true;
bool isFalse = false;

bool andActin = isTrue && isFalse; // true if both are true
bool orAction = isTrue || isFalse; // true if one of them is true
bool convertedTrue = !isTrue; // change to opposide value

Console.WriteLine(andActin);
Console.WriteLine(orAction);
Console.WriteLine(convertedTrue);


Console.WriteLine();
Console.WriteLine("-------------------------");
Console.WriteLine();


int x = 4;

x += 2; // x = x + 2
Console.WriteLine(x);

x -= 3; // x = x - 3
Console.WriteLine(x);


Console.WriteLine();
Console.WriteLine("-------------------------");
Console.WriteLine();


//// 1. please enter user name
//Console.WriteLine("Please enter your name?"); // Console.Write("Please.." - will continue in the same line

//// 2. waiting for data
//string userName = Console.ReadLine();

//// 3. hello wording with user name: "Hello: {name}"
//Console.WriteLine("Hello: " + userName + "!");


//Console.WriteLine("Please enter sumber?");

//string userNumberString = Console.ReadLine();
//int userNumber = int.Parse(userNumberString);

//int byTenLarger = userNumber + 10;
//Console.WriteLine("Number larger by 10: " + byTenLarger);


int positiveNumber = 15;
int negativeNumber = -15;

int positiveAbs = Math.Abs(positiveNumber);
int negativeAbs = Math.Abs(negativeNumber);

Console.WriteLine("Default negative: " + negativeNumber);
Console.WriteLine(positiveAbs);
Console.WriteLine(negativeAbs);


Console.WriteLine();
Console.WriteLine("-------------------------");
Console.WriteLine();


int maxNumberHigh = 40;
int maxNumberLow = 39;

int largerNumber = Math.Max(maxNumberHigh, maxNumberLow);
Console.WriteLine("Larger number: " + largerNumber);


Console.WriteLine();
Console.WriteLine("-------------------------");
Console.WriteLine();


int minNumberHigh = 40;
int minNumberLow = 39;

int smallerNumber = Math.Min(minNumberHigh, minNumberLow);
Console.WriteLine("Smallest number: " + smallerNumber);


Console.WriteLine();
Console.WriteLine("-------------------------");
Console.WriteLine();

double roundableNumber = 123.34;
double rounded = Math.Round(roundableNumber, 1);

Console.WriteLine("Number rounded: " + rounded);


Console.WriteLine();
Console.WriteLine("-------------------------");
Console.WriteLine();

//interpolacija

string name = "Elizabete";
int age2 = 90;

string formattedMessage = $"Hello {name} it is very nice to see you at your age {age2} wich ios very greacefull!";

Console.WriteLine(formattedMessage);

