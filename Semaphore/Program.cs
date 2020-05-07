using System;
using System.Net.NetworkInformation;
using System.Threading;
using System.Threading.Tasks;

namespace Semaphore
{
    class Program
    {
        static async Task Main(string[] args)
        {
        SemaphoreSlim gate = new SemaphoreSlim(10);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("start");
                await gate.WaitAsync();
                Console.WriteLine("Do some work");
                Console.WriteLine("Finish");
            }
        }
    }
}
