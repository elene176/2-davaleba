using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace _2_davaleba

    class Program
    {
    static void Main(string[] args)
    {

        // Declare variables
        float floatValue = (float)(1.0 / 7.0);
        double doubleValue = 1.0 / 7.0;
        decimal decimalValue = (decimal)(1.0 / 7.0);

        // Multiply each by 7
        float floatResult = floatValue * 7;
        double doubleResult = doubleValue * 7;
        decimal decimalResult = decimalValue * 7;

        // Print results
        Console.WriteLine($"Float Result: {floatResult}");
        Console.WriteLine($"Double Result: {doubleResult}");
        Console.WriteLine($"Decimal Result: {decimalResult}");
        Console.ReadKey();


        //Console.WriteLine("\nComparison:");
        //Console.WriteLine($"Float equals Double: {floatResult == doubleResult}");
        //Console.WriteLine($"Float equals Decimal: {floatResult == decimalResult}");
        //Console.WriteLine($"Double equals Decimal: {doubleResult == decimalResult}");
        //Console.ReadKey();

        Console.WriteLine("\nComparison:");
        Console.WriteLine($"Float equals Double: {Math.Abs(floatResult - (float)doubleResult) < 0.00001}");
        Console.WriteLine($"Float equals Decimal: {Math.Abs(floatResult - (float)decimalResult) < 0.00001}");
        Console.WriteLine($"Double equals Decimal: {Math.Abs(doubleResult - (double)decimalResult) < 0.00001}");
        Console.WriteLine("//===========================================");
        Console.ReadKey();

        // Declare variables
        int intValue = 10;
        double originalDoubleValue = 20.5;
        float originalfloatValue = 30.5f;
        decimal originaldecimalValue = 40.5m;

        // Implicit conversions
        double implicitDouble = intValue; // int to double (implicit)
        float implicitFloat = (float)doubleValue; // double to float (implicit, but can lose precision)

        // Explicit conversions
        int explicitIntFromDouble = (int)doubleValue; // double to int (explicit)
        decimal explicitDecimalFromFloat = (decimal)floatValue; // float to decimal (explicit)

        // Output results
        Console.WriteLine("Original Values:");
        Console.WriteLine($"intValue: {intValue}");
        Console.WriteLine($"doubleValue: {doubleValue}");
        Console.WriteLine($"floatValue: {floatValue}");
        Console.WriteLine($"decimalValue: {decimalValue}");

        Console.WriteLine("\nConversions:");
        Console.WriteLine($"Implicit Double from int: {implicitDouble}");
        Console.WriteLine($"Implicit Float from double: {implicitFloat}");
        Console.WriteLine($"Explicit Int from double: {explicitIntFromDouble}");
        Console.WriteLine($"Explicit Decimal from float: {explicitDecimalFromFloat}");

        // Demonstrating conversion from decimal to other types
        double explicitDoubleFromDecimal = (double)decimalValue; // decimal to double (explicit)
        float explicitFloatFromDecimal = (float)decimalValue; // decimal to float (explicit)

        Console.WriteLine($"\nExplicit Double from decimal: {explicitDoubleFromDecimal}");
        Console.WriteLine($"Explicit Float from decimal: {explicitFloatFromDecimal}");
        Console.ReadKey();
        // Initialize variables
        int x = 15;
        int b = 25;

        // Display values before swap
        Console.WriteLine($"Before:\nint x = {x};\nint b = {b};");

        // Swap values
        int temp = x; // Store the value of x in a temporary variable
        x = b;        // Assign the value of b to x
        b = temp;     // Assign the value from the temporary variable to b

        // Display values after swap
        Console.WriteLine($"After:\nint x = {x};\nint b = {b};");
        Console.ReadKey();

        // Get user input for weight and height
        Console.Write("Enter your weight in kilograms: ");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter your height in meters: ");
        double height = Convert.ToDouble(Console.ReadLine());

        // Calculate BMI
        double bmi = weight / (height * height);

        // Display BMI result
        Console.WriteLine("\nYour BMI is: " + bmi);

        // Provide tips based on BMI
        if (bmi < 18.5)
        {
            Console.WriteLine("You are underweight. Consider consulting a healthcare provider for advice.");
        }
        else if (bmi >= 18.5 && bmi < 24.9)
        {
            Console.WriteLine("You have a normal weight. Keep up the good work!");
        }
        else if (bmi >= 25 && bmi < 29.9)
        {
            Console.WriteLine("You are overweight. Consider adopting a healthier lifestyle.");
        }
        else
        {
            Console.WriteLine("You are obese. It's important to consult a healthcare provider for guidance.");

        }
        Console.ReadKey();
    }

}
