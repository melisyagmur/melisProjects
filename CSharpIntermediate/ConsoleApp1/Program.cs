using System;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 2; i++)
            {
                var time = new StartEnd();
                var start = time.StartTime();
                var end = time.EndTime();
                Console.WriteLine(time.GetTime(end, start));
                Console.WriteLine("press enter if you want to start again");
                Console.ReadLine();
            }
     


        }
    }
}
