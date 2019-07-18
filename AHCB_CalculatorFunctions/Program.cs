using System;

namespace AHCB_CalculatorFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, sum, difference, product, quotient, celsius;
            string calculationType = CalculationType();

            if (calculationType.Equals("Addition", StringComparison.OrdinalIgnoreCase))
            {
                int numberOfNumbers = NumberOfNumbers();
                switch (numberOfNumbers)
                {
                    case 2:
                        a = AcceptNumber();
                        b = AcceptNumber();
                        sum = AddNumbers(a, b);
                        Console.WriteLine($"{a} + {b} = {sum}");
                        break;
                    case 3:
                        a = AcceptNumber();
                        b = AcceptNumber();
                        c = AcceptNumber();
                        sum = AddNumbers(a, b, c);
                        Console.WriteLine($"{a} + {b} + {c} = {sum}");
                        break;
                    case 4:
                        a = AcceptNumber();
                        b = AcceptNumber();
                        c = AcceptNumber();
                        d = AcceptNumber();
                        sum = AddNumbers(a, b, c, d);
                        Console.WriteLine($"{a} + {b} + {c} + {d} = {sum}");
                        break;
                }
            }
            else if (calculationType.Equals("Subtraction", StringComparison.OrdinalIgnoreCase))
            {
                int numberOfNumbers = NumberOfNumbers();
                switch (numberOfNumbers)
                {
                    case 2:
                        a = AcceptNumber();
                        b = AcceptNumber();
                        difference = SubtractNumbers(a, b);
                        Console.WriteLine($"{a} + {b} = {difference}");
                        break;
                    case 3:
                        a = AcceptNumber();
                        b = AcceptNumber();
                        c = AcceptNumber();
                        difference = SubtractNumbers(a, b, c);
                        Console.WriteLine($"{a} + {b} + {c} = {difference}");
                        break;
                    case 4:
                        a = AcceptNumber();
                        b = AcceptNumber();
                        c = AcceptNumber();
                        d = AcceptNumber();
                        difference = SubtractNumbers(a, b, c, d);
                        Console.WriteLine($"{a} + {b} + {c} + {d} = {difference}");
                        break;
                }
            }
            else if (calculationType.Equals("Multiplication", StringComparison.OrdinalIgnoreCase))
            {
                int numberOfNumbers = NumberOfNumbers();
                switch (numberOfNumbers)
                {
                    case 2:
                        a = AcceptNumber();
                        b = AcceptNumber();
                        product = MultiplyNumbers(a, b);
                        Console.WriteLine($"{a} + {b} = {product}");
                        break;
                    case 3:
                        a = AcceptNumber();
                        b = AcceptNumber();
                        c = AcceptNumber();
                        product = MultiplyNumbers(a, b, c);
                        Console.WriteLine($"{a} + {b} + {c} = {product}");
                        break;
                    case 4:
                        a = AcceptNumber();
                        b = AcceptNumber();
                        c = AcceptNumber();
                        d = AcceptNumber();
                        product = MultiplyNumbers(a, b, c, d);
                        Console.WriteLine($"{a} + {b} + {c} + {d} = {product}");
                        break;
                }
            }
            else if (calculationType.Equals("Division",StringComparison.OrdinalIgnoreCase))
            {
                int numberOfNumbers = NumberOfNumbers();
                switch (numberOfNumbers)
                {
                    case 2:
                        a = AcceptNumber();
                        b = AcceptNumber();
                        quotient = DivideNumbers(a, b);
                        Console.WriteLine($"{a} + {b} = {quotient}");
                        break;
                    case 3:
                        a = AcceptNumber();
                        b = AcceptNumber();
                        c = AcceptNumber();
                        quotient = DivideNumbers(a, b, c);
                        Console.WriteLine($"{a} + {b} + {c} = {quotient}");
                        break;
                    case 4:
                        a = AcceptNumber();
                        b = AcceptNumber();
                        c = AcceptNumber();
                        d = AcceptNumber();
                        quotient = DivideNumbers(a, b, c, d);
                        Console.WriteLine($"{a} + {b} + {c} + {d} = {quotient}");
                        break;
                }
            }
            else
            {
                celsius = ConvertFarenheitToCelsius();
                Console.WriteLine($"Your temperature: {celsius}C");
            }
        }

        static public int NumberOfNumbers()
        {
            bool userInput;
            int result;

            do
            {
                Console.WriteLine("How many numbers will be used in your calculation?");
                Console.WriteLine("Enter 2, 3, or 4:");
                userInput = int.TryParse(Console.ReadLine(), out result);

                if (!userInput || (result < 2 || result > 4))
                {
                    Console.WriteLine("That was not a valid entry.");
                    userInput = false;
                }
            }
            while (!userInput);

            return result;
        }

        static public double AcceptNumber()
        {
            bool userInput;
            double result;

            do
            {
                Console.WriteLine("Enter a number:");
                userInput = double.TryParse(Console.ReadLine(), out result);

                if (!userInput)
                {
                    Console.WriteLine("That was not a valid entry.");
                }
            }
            while (!userInput);

            return result;
        }

        static public string CalculationType()
        {
            bool userInput = false;
            string userResponse;

            do
            {
                Console.WriteLine("What calculation type are you using on your numbers?");
                Console.WriteLine("Enter one of the following values:");
                Console.WriteLine("Addition");
                Console.WriteLine("Subtraction");
                Console.WriteLine("Multiplication");
                Console.WriteLine("Division");
                Console.WriteLine("Convert to Celsius");

                userResponse = Console.ReadLine();
                if (!(userResponse.Equals("Addition", StringComparison.OrdinalIgnoreCase) ||
                    userResponse.Equals("Subtraction", StringComparison.OrdinalIgnoreCase) ||
                    userResponse.Equals("Multiplication", StringComparison.OrdinalIgnoreCase) ||
                    userResponse.Equals("Division", StringComparison.OrdinalIgnoreCase) ||
                    userResponse.Equals("Convert to Celsius",StringComparison.OrdinalIgnoreCase)))
                {
                    Console.WriteLine("That was not a valid entry.");
                }
                else
                {
                    userInput = true;
                }
            }
            while (!userInput);
            return userResponse;
        }

        static public double AddNumbers(double a, double b)
        {
            return a + b;
        }

        static public double AddNumbers(double a, double b, double c)
        {
            return a + b + c;
        }

        static public double AddNumbers(double a, double b, double c, double d)
        {
            return a + b + c + d;
        }

        static public double SubtractNumbers(double a, double b)
        {
            return a - b;
        }

        static public double SubtractNumbers(double a, double b, double c)
        {
            return a - b - c;
        }

        static public double SubtractNumbers(double a, double b, double c, double d)
        {
            return a - b - c - d;
        }

        static public double MultiplyNumbers(double a, double b)
        {
            return a * b;
        }

        static public double MultiplyNumbers(double a, double b, double c)
        {
            return a * b * c;
        }

        static public double MultiplyNumbers(double a, double b, double c, double d)
        {
            return a * b * c * d;
        }

        static public double DivideNumbers(double a, double b)
        {
            return a / b;
        }

        static public double DivideNumbers(double a, double b, double c)
        {
            return a / b / c;
        }

        static public double DivideNumbers(double a, double b, double c, double d)
        {
            return a / b / c / d;
        }

        static public double ConvertFarenheitToCelsius()
        {
            bool userInput;
            double farenheit;

            do
            {
                Console.WriteLine("Enter a number to convert to Celsius:");
                userInput = double.TryParse(Console.ReadLine(), out farenheit);

                if (!userInput)
                {
                    Console.WriteLine("That was not a valid entry.");
                }
            }
            while (!userInput);

            double celsius = (farenheit - 32) / 1.8;
            return celsius;
        }
    }
}