using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Asynchronous_Code
{
    class Program
    {
        // A task is a token that represents whether or not the async call succeeds or not.
        static async Task DoSomething()
        {
            var client = new HttpClient();
            var page = await client.GetStringAsync("http://Microsoft.com");
            Console.WriteLine(page);
        }

        static async void MainAsync()
        {
            Console.WriteLine(Thread.CurrentThread.Name);
            var result = await AddNumbers(1, 3);
            Console.WriteLine(result);
            Console.WriteLine(Thread.CurrentThread.Name);
        }

        static async Task<int> AddNumbers(int val1, int val2)
        {
            await Task.Delay(3*1000);
            return val1 + val2;
        }

        static void Main(string[] args)
        {
            MainAsync();
            //DoSomething().Wait();
            Console.ReadLine();
        }
    }
}
