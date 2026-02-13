using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("How many grades do you want to give to the machine?");
        int arraySize = int.Parse(Console.ReadLine());

        //declare a new int array at the size of user's number
        int[] grades = new int[arraySize];
        int sum = 0;
        double deciSum = 0;
        for (int i = 0; i < arraySize; i++)
        {
            Console.WriteLine("Enter your grade number " + (i + 1));
            grades[i] = int.Parse(Console.ReadLine());
            sum += grades[i];
        }
        deciSum = sum;
        string gradeTotal = (deciSum/arraySize).ToString();
        Console.WriteLine("Your grade average is " + gradeTotal);
    }
}