using System;
using System.Diagnostics;
using System.Globalization;

class Program
{
    static void Main()
    {
        int n = 80000; // number of random numbers to generate
        double[,] numbers;
        Stopwatch timer = new Stopwatch();

        numbers = GenerateRandomNumbers(n);

        timer.Start();
        AddDoubles(numbers,n);
        timer.Stop();
        Console.WriteLine("Doubles");
        Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + " ms   "
                            + timer.ElapsedTicks + " ticks\n");
        float doubleTicks = (float)timer.ElapsedTicks;

        timer.Reset();  //RESET THE TIMER (ADD THIS FOR EVERY ADDITIONAL OPERATION)

        // int i;
        // for(i=0; i<n; ++i)
        // {
        // Console.WriteLine(numbers[i,0] + " " + numbers[i,1] + " " + numbers[i,2]);
        // }

        timer.Start();
        AddFloats(numbers,n);
        timer.Stop();
        Console.WriteLine("Floats");
        Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + " ms   "
                            + timer.ElapsedTicks + " ticks\n");
        float floatTicks = (float)timer.ElapsedTicks;

        Console.WriteLine("Ratio = " + doubleTicks/floatTicks);

        // int i;
        // for(i=0; i<n; ++i)
        // {
        // Console.WriteLine(numbers[i,0] + " " + numbers[i,1] + " " + numbers[i,2]);
        // }

    }

    // Function to generate an array of random numbers
    static double[,] GenerateRandomNumbers(int count)
    {
        Random rand = new Random(); // instantiate random number
        double[,] num = new double[count,3]; // make array
        for(int i=0; i<count; ++i)
        {
            num[i,0] = 10000.0*rand.NextDouble(); //fill in elements of array
            num[i,1] = 10000.0*rand.NextDouble();
        }

        // double number = 10.0*rand.NextDouble();
        return num; // returns reference array
    }


    // Function that adds Doubles in the supplied 2d array
    static void AddDoubles(double[,] nums, int count)
    {
        int i;
        for(i=0; i<count; ++i)
        {
            nums[i,2] = nums[i,0] + nums[i,1];
        }
    }
    // Function that adds Floats in the supplied 2d array
    static void AddFloats(double[,] nums, int count)
    {
        int i;
        for(i=0; i<count; ++i)
        {
            nums[i,2] = (float)nums[i,0] + (float)nums[i,1];
        }
    }
}