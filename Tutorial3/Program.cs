using System.Data;

namespace Tutorial3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello, World! This is Tutorial 3.");
            System.Console.WriteLine("Please select which method you want to run: ");
            System.Console.WriteLine("1. UniaryOperator");
            System.Console.WriteLine("2. BinaryOperator");
            System.Console.WriteLine("3. TernaryOperator");
            System.Console.WriteLine("4. NullCoalescingOperator");
            System.Console.WriteLine("5. ConditionalStatement");
            System.Console.WriteLine("6. Loops");
            System.Console.WriteLine("7. umpStatements");
            System.Console.WriteLine("8. ExceptionHandling");
            string userInput = System.Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    UniaryOperator();
                    break;
                case "2":
                    BinaryOperator();
                    break;
                case "3":
                    TernaryOperator();
                    break;
                case "4":
                    NullCoalescingOperator();
                    break;
                case "5":
                    ConditionalStatement();
                    break;
                case "6":
                    Loops();
                    break;
                case "7":
                    JumpStatements();
                    break;
                case "8":
                    ExceptionHandling();
                    break;
                default:
                    System.Console.WriteLine("Invalid Input");
                    break;
            }
        }

        static void UniaryOperator()
        {
            System.Console.WriteLine("----------------------------------Uniary Operator----------------------------------");
            System.Console.WriteLine("Post Increment");
            int x = 10;
            int y = x++;
            System.Console.WriteLine($"x= {x}, y={y}"); // output(x=11, y=10)

            System.Console.WriteLine("Pre Increment");
            int a = 10;
            int b = ++a;
            System.Console.WriteLine($"a={a}, b={b}"); // output: (a=11, b=11)

            System.Console.WriteLine("Post Decreament");
            int p = 10;
            int q = p--;
            System.Console.WriteLine($"p={p}, q={q}"); // output(p=9, q=10)

            System.Console.WriteLine("Post Decreament");
            int r = 10;
            int s = --p;
            System.Console.WriteLine($"r={r}, s={s}"); // output(r=9, s=9)
            System.Console.WriteLine();
        }

        static void BinaryOperator()
        {
            System.Console.WriteLine("----------------------------------Binary Operator----------------------------------");
            int score = 100;

            System.Console.WriteLine($"Initial Score: {score}");
            score -= 10;
            System.Console.WriteLine($"After -10: {score}");
            score += 20;
            System.Console.WriteLine($"Score after +5 on top of {score}");
            score /= 2;
            System.Console.WriteLine($"Score after /2 on top of {score}");
            score *= 3;
            System.Console.WriteLine($"Score after *3 on top of {score}");
            System.Console.WriteLine();

            System.Console.WriteLine("----------------------------------Rational Operators----------------------------------");
            int age = 18;
            System.Console.WriteLine($"initial value of age is {age}");
            System.Console.WriteLine($"age == 20: {age == 20}");
            System.Console.WriteLine($"age != 20: {age != 20}");
            System.Console.WriteLine($"age > 20: {age > 20}");
            System.Console.WriteLine($"age >= 20: {age >= 20}");
            System.Console.WriteLine($"age < 20: {age < 20}");
            System.Console.WriteLine($"age <= 20: {age <= 20}");
            System.Console.WriteLine();

            System.Console.WriteLine("----------------------------------Logical Operator----------------------------------");
            bool hasLicense = true;
            int driveAge = 25;
            bool canDrive = hasLicense && (driveAge >= 20);
            System.Console.WriteLine($"Can drive: {canDrive}");
            System.Console.WriteLine();
        }

        static void TernaryOperator()
        {
            System.Console.WriteLine("----------------------------------Ternary Operator----------------------------------");
            int userAge = 25;
            string ageType = userAge > 10 ? "Adult" : "Not Adult";
            System.Console.WriteLine($"THe user is {ageType}");

            string ageGroup = (userAge < 18) ? "Minor" : (userAge > 18) ? "Adult" : "Senior";
            System.Console.WriteLine(ageGroup);
            System.Console.WriteLine();
        }

        static void NullCoalescingOperator()
        {
            System.Console.WriteLine("----------------------------------Null Coalescing Operator------------------------");

            string? studentName = "Ram";
            System.Console.WriteLine(studentName ?? "Samir Bhattarai");
            System.Console.WriteLine();

        }

        static void ConditionalStatement()
        {
            System.Console.WriteLine("----------------------------------Conditional Statement----------------------------------");
            double temperature = 10;
            if (temperature < 16)
            {
                System.Console.WriteLine($"Temperature is below 16, Please avoid visiting outside");
            }
            else if (temperature <= 20)
            {
                System.Console.WriteLine("Get some warm clothes before getting outside");
            }
            else
            {
                System.Console.WriteLine("It's okay to get outside if you need");
            }
            System.Console.WriteLine();

            System.Console.WriteLine("----------------------------------Switch Case Statement----------------------------------");
            int dayNumber = 2;
            switch (dayNumber)
            {
                case 1:
                    System.Console.WriteLine("Sunday");
                    break;
                case 2:
                    System.Console.WriteLine("Monday");
                    break;
                case 3:
                    System.Console.WriteLine("Tuesday");
                    break;
                case 4:
                    System.Console.WriteLine("Wednesday");
                    break;
                case 5:
                    System.Console.WriteLine("Thursday");
                    break;
                case 6:
                    System.Console.WriteLine("Friday");
                    break;
                case 7:
                    System.Console.WriteLine("Saturday");
                    break;
                default:
                    System.Console.WriteLine("The number is out of bound, Please select correct number");
                    break;
            }
            System.Console.WriteLine();
        }

        static void Loops()
        {
            System.Console.WriteLine("----------------------------------While Loop----------------------------------");
            int counter = 1;
            int sum = 0;
            while (counter <= 5)
            {
                System.Console.WriteLine($"Counter: {counter}");
                sum += counter;
                counter++;
            }
            System.Console.WriteLine($"Sum: {sum}");
        }

        static void JumpStatements()
        {
            System.Console.WriteLine("----------------------------------Jump Statement----------------------------------");
            System.Console.WriteLine("Using break in a loop");

            for (int i = 1; i <= 10; i++)
            {
                if (i == 6)
                {
                    System.Console.WriteLine("Breaking the loop at i =6");
                    break;
                }
                System.Console.WriteLine($"i ={i}");

            }

            System.Console.WriteLine();
            System.Console.WriteLine("Using continue in a loop");
            for (int j = 0; j <= 5; j++)
            {
                if (j % 2 == 0)
                {
                    continue;
                }
                System.Console.WriteLine($"j = {j}");

            }
            System.Console.WriteLine();
            System.Console.WriteLine("Odd number using jump statement from 1 to 10");
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                System.Console.WriteLine(i);
            }
        }

        static void ExceptionHandling()
        {
            System.Console.WriteLine("----------------------------------Exception Handling----------------------------------");
            int a = 5;
            int b = 0;
            try
            {
                int divide = a / b;
                System.Console.WriteLine(divide);
            }
            catch (DivideByZeroException)
            {
                System.Console.WriteLine("Encountered Divide by Zero Exception!!!");
            }
            finally
            {
                System.Console.WriteLine("This is finally block, it run every time.");
            }
        }
    }
}