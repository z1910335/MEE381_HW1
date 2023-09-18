
using System.Diagnostics;
using System.Globalization;
//ch-ch-ch-chia
class Program
{
    static void Main()
    {
        int n = 80000; // number of random numbers to generate
        double[,] numbers;
        Stopwatch timer = new Stopwatch();

        numbers = GenerateRandomNumbers(n);

        //First Timer
        timer.Start();
        AddNumbers(numbers,n);
        timer.Stop();
        Console.WriteLine("Additions");
        Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + " ms   "
                            + timer.ElapsedTicks + " ticks\n");
        float addTicks = timer.ElapsedTicks;

        //Second Timer
        timer.Start();
        MultiplyNumbers(numbers,n);
        timer.Stop();
        Console.WriteLine("Multiplications");
        Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + " ms   "
                            + timer.ElapsedTicks + " ticks\n");
        float multTicks = timer.ElapsedTicks;

        Console.WriteLine("Ratio = " + addTicks/multTicks);
        Console.WriteLine("Ratio = " + multTicks/addTicks);

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
            num[i,0] = 100.0*rand.NextDouble(); //fill in elements of array
            num[i,1] = 100.0*rand.NextDouble();
        }

        // double number = 10.0*rand.NextDouble();
        return num; // returns reference array
    }

    // Function that adds numbers in the supplied 2d array
    static void AddNumbers(double[,] nums, int count)
    {
        int i;
        for(i=0; i<count; ++i)
        {
            nums[i,1] = nums[i,0] * nums[i,0];
        }
    }

    // Function that multiplies numbers in the supplied 2d array
    static void MultiplyNumbers(double[,] nums, int count)
    {
        int i;
        for(i=0; i<count; ++i)
        {
            nums[i,2] = nums[i,0] * nums[i,1];
        }
    }
}