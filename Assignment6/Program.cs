using System;

class Program
{
    static void Main()

    {
        #region Number1 
        /*
 Passing by Value
          The reference to the object is passed to the method.
         Any modifications to the object's properties will reflect outside the method 
        because the object is shared.
       if the reference itself is reassigned to a new object inside the method, 
        this change will not be visible outside the method because the reference copy
        is modified.
Passing by Reference
The method receives a reference to the original reference.
Any changes made to the object's properties or reassignments of the 
        reference are reflected outside the method.*/
        /*
        MyClass myObject = new MyClass { Value = 10 };

        Console.WriteLine("Original Value: " + myObject.Value);

        // Passing by value
        ModifyByValue(myObject);
        Console.WriteLine("After ModifyByValue: " + myObject.Value);

        // Passing by reference
        ModifyByReference(ref myObject);
        Console.WriteLine("After ModifyByReference: " + myObject.Value);
    }

    static void ModifyByValue(MyClass obj)
    {
        // Modifying the object's property (affects the original object)
        obj.Value = 20;

        // Reassigning the reference (does not affect the original reference)
        obj = new MyClass { Value = 30 };
    }

    static void ModifyByReference(ref MyClass obj)
    {
        // Modifying the object's property
        obj.Value = 40;

        // Reassigning the reference (affects the original reference)
        obj = new MyClass { Value = 50 };
        */

        #endregion
        #region Number2
        /*
        // Get input from the user
        Console.Write("Enter the first number for summation: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number for summation: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Enter the first number for subtraction: ");
        int num3 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number for subtraction: ");
        int num4 = int.Parse(Console.ReadLine());

        // Call the function
        (int sumResult, int subtractResult) = Calculate(num1, num2, num3, num4);

        // Display results
        Console.WriteLine($"Summation Result: {sumResult}");
        Console.WriteLine($"Subtraction Result: {subtractResult}");
    }

    static (int, int) Calculate(int a, int b, int c, int d)
    {
        int sum = a + b;        // Summation of first two numbers
        int subtract = c - d;   // Subtraction of last two numbers
        return (sum, subtract); // Return both results as a tuple
    }
        */
        #endregion
        #region Number3
        /*
        // Define an array
        int[] numbers = { 5, 12, 8, 20, 3 };

        // Variables to store the min and max values
        int min = 0, max = 0;

        // Call the MinMaxArray function
        MinMaxArray(numbers, ref min, ref max);

        // Display the results
        Console.WriteLine($"Minimum Value: {min}");
        Console.WriteLine($"Maximum Value: {max}");
    }

    static void MinMaxArray(int[] arr, ref int min, ref int max)
    {
        // Ensure the array is not empty
        if (arr.Length == 0)
        {
            throw new ArgumentException("Array must not be empty.");
        }

        // Initialize min and max with the first element
        min = arr[0];
        max = arr[0];

        // Loop through the array to find min and max
        foreach (int num in arr)
        {
            if (num < min)
            {
                min = num;
            }
            if (num > max)
            {
                max = num;
            }
        }
        */
        #endregion
    }
}

class MyClass
{
    public int Value { get; set; }
}