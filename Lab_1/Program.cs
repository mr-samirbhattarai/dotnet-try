// // See https://aka.ms/new-console-template for more information

// Task 1
// String userName = "Samir Bhattarai";
// int LuckyNumber = 7;

// Console.WriteLine($"Hello, {userName}! Your lucky number is {LuckyNumber}.");



// Task 2: Constants  [ 5 Minutes ]
// Create a class named Circle.
// Inside the class, declare a constant variable named PI and initialize it with the value 3.14.
// In the Main() method of Program.cs,
// Try to modify the value of PI of the Circle class and observe the compilation error and explain the error. 
// Additionally, you can create methods to calculate area and perimeter of the circle.





// // Task 2; Constants

// // Create a class named Circle.
// namespace Lab_1
// {
//     class Circle
//     {
//         // Inside the class, declare a constant variable named PI and initialize it with the value 3.14.
//         const double PI = 3.14;
//         double radius = 4;
//         private double Area()
//         {
//             double areaOfCircle = PI * radius * radius;
//             return areaOfCircle;
//         }

//         private double Perimeter()
//         {
//             double perimeterOfCircle = 2 * PI * radius;
//             return perimeterOfCircle;
//         }
//         static void Main()
//         {
//             // In the Main() method of Program.cs, try to modify the value of PI of the Circle class and observe the compilation error and explain the error. 
//             // PI = 3.25;

//             // Additionally, you can create methods to calculate area and perimeter of the circle.
//             Circle circleArea = new Circle();
//             double areaOfCircle = circleArea.Area();
//             double perimeterOfCircle = circleArea.Perimeter();


//             Console.WriteLine($"The area of Circle is: {areaOfCircle}");
//             Console.WriteLine($"The perimeter of Circle is: {perimeterOfCircle}");
//         }
//     }
// }

// Task 3: Task 3: Data Types and Type Conversion 
// Declare and initialize variables of the following types: byte, short, int, long, float, double, decimal, char, bool.
// byte age = 20;
// int distance = 100;
// long phNumber = 9800000000L;

// float gpa = 3.75f;
// double height = 5.9;
// decimal accountBalance = 1500.50m;

// char grade = 'A';
// bool isAllowed = true;


// // Convert the integer value 42 to a string and store it in a new variable.
// int valueAsInt = 42;
// String valueAsString = valueAsInt.ToString();

// // Convert a string "3.14" to a double and store it in a new variable.
// String piString = "3.14";
// double piAsDouble = Convert.ToDouble(piString);

// // Print all variables to the console with appropriate labels showing their types and values.
// Console.WriteLine($"Byte age: {age}");
// Console.WriteLine($"Int distance: {distance}");
// Console.WriteLine($"Long phone number: {phNumber}");
// Console.WriteLine($"Float GPA: {gpa}");
// Console.WriteLine($"Double height: {height}");
// Console.WriteLine($"Decimal account balance: {accountBalance}");
// Console.WriteLine($"Char grade: {grade}");
// Console.WriteLine($"Bool is allowed: {isAllowed}");
// Console.WriteLine($"Converted String value: {valueAsString}");
// Console.WriteLine($"Converted Double value: {piAsDouble}");


// // Task 4: Array and Array Methods

// // Creates a single-dimensional integer array containing 5 of your favorite numbers.
// int[] singleDimensionalArray = { 1, 4, 6, 7, 3, 9 };

// // Uses Array.Sort() to sort the array in ascending order.
// Array.Sort(singleDimensionalArray);

// // Uses Array.Reverse() to reverse the sorted array.
// Array.Reverse(singleDimensionalArray);

// // Prints each element of the array using a for loop.
// for (int i = 0; i < singleDimensionalArray.Length; i++)
// {
//     Console.WriteLine($"Element at index {i}: {singleDimensionalArray[i]}");
// }

// // Uses Array.IndexOf() to find the position of a specific number in the array.
// int index = Array.IndexOf(singleDimensionalArray, 9);
// Console.WriteLine($"Index of 9: {index}");


// // Task 5: Date Time and Time Span

// // Creates a DateTime variable representing your birthdate.
// DateTime birthdate = new DateTime(2004, 11, 19);

// // Creates another DateTime variable representing the current date and time.
// DateTime currentDate = DateTime.Now;

// // Calculates your age using TimeSpan (you'll need to subtract the two DateTime values).
// TimeSpan age = currentDate - birthdate;

// // Prints your birthdate, the current date, and your age in years.
// Console.WriteLine($"Birthdate: {birthdate}");
// Console.WriteLine($"Current Date: {currentDate}");
// Console.WriteLine($"Age in years: {age.Days / 365}");

// // Adds 10 days to your birthdate and prints the resulting date.
// DateTime agePlusTenDays = birthdate.AddDays(10);
// Console.WriteLine($"Birthdate after adding 10 days: {agePlusTenDays}");


//  Generic Collections (List and Dictionary)

// Creates a List<string> containing the names of 3 of your favorite fruits.
List<String> favoriteFruits = new List<String>()
{
    "Mango",
    "Banana",
    "Apple"
};
// Adds a new fruit to the list.
favoriteFruits.Add("Grapes");

// Removes one fruit from the list.
favoriteFruits.Remove("Banana");

// Prints all fruits in the list using a foreach loop.
foreach (String fruit in favoriteFruits)
{
    Console.WriteLine(fruit);
}

// Creates a Dictionary<int, string> where keys are fruit IDs (1,2,3) and values are the fruit names.
Dictionary<int, String> fruitDictionary = new Dictionary<int, String>()
{
    {1, "Mango" },
    {2, "Banana" },
    {3, "Apple" }
};

// Adds a new entry to the dictionary and prints all key-value pairs.
fruitDictionary.Add(4, "Grapes");

for (int i = 1; i < fruitDictionary.Count; i++)
{
    Console.WriteLine($"Key: {i}, Value: {fruitDictionary[i]}");
}