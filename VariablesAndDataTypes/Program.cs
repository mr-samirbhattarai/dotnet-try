// See https://aka.ms/new-console-template for more information
/* Console.WriteLine("Hello, World!");
    Console.WriteLine("This is Variable and datatype");
    Console.WriteLine("This is Lecture 2");
*/

// single line comment

// Variable

// Numerical values byte, int, long
using System.Transactions;


/// document comment
byte numByte = 255;
int numInt = 30;
long numLong = 1234567898762325431L;

Console.WriteLine(numByte);
Console.WriteLine(numInt);
Console.WriteLine(numLong);

// String
String firstName = "Samir";
String lastName = "Bhattarai";
Console.WriteLine(firstName);
Console.WriteLine(lastName);

// float(f), double, decimal(m)
float percentage1 = 123.33f;
double percentage2 = 1234.987;
decimal percentage3 = 21.028437023984m;

System.Console.WriteLine(percentage1);
System.Console.WriteLine(percentage2);
System.Console.WriteLine(percentage3);

// character(char)
char letter = 'a';
Console.WriteLine(letter);

// Type Conversion

/* 
    converting from one data type to another one
    byte -> int -> long (implicit)
    long -> int -> byte (explicit)
*/

int originalNum = 5;
double doubleNum = originalNum;
long longNum = originalNum;

System.Console.WriteLine(originalNum);
System.Console.WriteLine(doubleNum);
System.Console.WriteLine(longNum);

int intNum = (int)doubleNum;
System.Console.WriteLine(intNum);

// Arrays

int[] numberArray = { 1, 2, 3, 4, 5, 6 };

Array.Sort(numberArray);
Array.Reverse(numberArray);
int pos = Array.IndexOf(numberArray, 4);
System.Console.WriteLine("The position of 4 is " + pos);

// DateTime

DateTime timeNow = DateTime.Now;
DateTime utcTIme = DateTime.UtcNow;
System.Console.WriteLine("Current time is " + timeNow);
System.Console.WriteLine("Current UTC time is " + DateTime.UtcNow);

TimeSpan timeDifference = timeNow - utcTIme;
System.Console.WriteLine("The time difference is " + timeDifference);
System.Console.WriteLine("The time difference in minutes is " + timeDifference.TotalMinutes);

// Current Asia/Kathmandu time is ..., utc time is ... and time difference is ...
System.Console.WriteLine();
System.Console.WriteLine($"Current Asia/Kathmandu time is {timeNow}, utc time is {utcTIme} and time difference is {timeDifference} "); // interpolate

// Parsing
String stringNum = "5";
int num = int.Parse(stringNum);
int num2 = 7;
int sum = num + num2;

System.Console.WriteLine();
System.Console.WriteLine(num);
System.Console.WriteLine("The sum is " + sum);

int[] numberList = { 8, 3, 2, 5, 7 };
System.Console.WriteLine("The number at fist index is " + numberList[0]);

// for loop
for (int i = 0; i < numberList.Length; i++)
{
    System.Console.WriteLine(numberList[i]);
}

// foreach loop
foreach (int n in numberList)
{
    System.Console.WriteLine(n);
}

// Constant

const double pi = 3.14;
System.Console.WriteLine(pi);

// invalid declaration
// pi = 3.14;
// System.Console.WriteLine(pi);

int divide = 5 / 2;
System.Console.WriteLine(divide);

float divide1 = (float)5 / 2;
System.Console.WriteLine(divide1);

double divide2 = (double)5 / 2;
System.Console.WriteLine(divide2);

long divide3 = (long)5 / 2;
System.Console.WriteLine(divide3);


// londonmetid_intake_section