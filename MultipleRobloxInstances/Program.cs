using System;
using System.Threading;

namespace MultipleRobloxInstances
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Mutex mutex = new Mutex(true, "ROBLOX_singletonMutex");

            if (!mutex.WaitOne(TimeSpan.Zero, false))
            {
                Console.WriteLine("Made by NotAMonkeIRL");
                Console.WriteLine("Close your Roblox");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Made by NotAMonkeIRL");
            Console.WriteLine("You can open Roblox now.");
            Console.WriteLine("Keep this open while having your Roblox instances open. Press a key to exit.");
            Console.ReadKey();
            Console.WriteLine("Are you sure that you want to close all of your Instances?");
            Console.ReadKey();
            mutex.ReleaseMutex();
            mutex.Dispose();
        }
    }
}
