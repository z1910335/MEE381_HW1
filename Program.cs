using System;
using System.Diagnostics;
using System.Globalization;

class Program
{
    static void Main()
    {
        int n = 800000; // number of random numbers to generate
        double[,] numbers;
        Stopwatch timer = new Stopwatch();

        numbers = GenerateRandomNumbers(n);

        timer.Start();
        DirectMult(numbers,n);
        timer.Stop();
        Console.WriteLine("Direct Multiplication");
        Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + " ms   "
                            + timer.ElapsedTicks + " ticks\n");
        float directTicks = (float)timer.ElapsedTicks;

        timer.Reset();  //RESET THE TIMER (ADD THIS FOR EVERY ADDITIONAL OPERATION)

        // int i; // This is to test that values generated as expected
        // for(i=0; i<n; ++i)
        // {
        // Console.WriteLine(numbers[i,0] + " " + numbers[i,1]);
        // }

        timer.Start();
        MathPower(numbers,n);
        timer.Stop();
        Console.WriteLine("Power Function");
        Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + " ms   "
                            + timer.ElapsedTicks + " ticks\n");
        float powerTicks = (float)timer.ElapsedTicks;

        // int i; // This is to test that values generated as expected
        // for(i=0; i<n; ++i)
        // {
        // Console.WriteLine(numbers[i,0] + " " + numbers[i,1]);
        // }

        timer.Reset();  //RESET THE TIMER (ADD THIS FOR EVERY ADDITIONAL OPERATION)

       timer.Start();
        MathSquareroot(numbers,n);
        timer.Stop();
        Console.WriteLine("Square Root Function");
        Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + " ms   "
                            + timer.ElapsedTicks + " ticks\n");
        float sqrtTicks = (float)timer.ElapsedTicks;

        // int i; // This is to test that values generated as expected
        // for(i=0; i<n; ++i)
        // {
        // Console.WriteLine(numbers[i,0] + " " + numbers[i,1]);
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
        }

        return num; // returns reference array
    }


    // Function that uses direct multiplication
    static void DirectMult(double[,] nums, int count)
    {
        int i;
        for(i=0; i<count; ++i)
        {
            nums[i,1] = nums[i,0] * nums[i,0];
        }
    }
    // Function that uses Math.Pow
    static void MathPower(double[,] nums, int count)
    {
        int i;
        for(i=0; i<count; ++i)
        {
            nums[i,1] = Math.Pow(nums[i,0],2);
        }
    }
    // Function that uses Math.Sqrt Function
        static void MathSquareroot(double[,] nums, int count)
    {
        int i;
        for(i=0; i<count; ++i)
        {
            nums[i,1] = Math.Sqrt(nums[i,0]);
        }
    }
}