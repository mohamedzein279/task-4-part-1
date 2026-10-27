
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        try
        {
            Console.WriteLine("Enter the number of elements:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());

                if (numbers.Contains(num))
                {
                    throw new Exception("Duplicate number: " + num);
                }

                numbers.Add(num);
            }

            Console.WriteLine("All numbers are unique.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

