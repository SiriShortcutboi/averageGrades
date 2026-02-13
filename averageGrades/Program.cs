using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("How many grades will you enter?");
        int size = int.Parse(Console.ReadLine());

        //declare a new int array at the size of user's number
        int[] grades = new int[size];
        int sum = 0;
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("Enter grade " + (i + 1) + ":");
            grades[i] = int.Parse(Console.ReadLine());
            sum += grades[i];
        }
        Console.WriteLine(sum/size);
    }
}