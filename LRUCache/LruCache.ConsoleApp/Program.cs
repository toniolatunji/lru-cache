using LruCache.Service.Contract;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace LruCache.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = ServiceRegistration.GetServiceProvider();

            var lruCacheService = serviceProvider.GetService<ILruCacheService>();

            lruCacheService.ReInitializeCache();

            var input1 = new string[] { "A", "B", "C", "D", "A", "E", "D", "Z" };

            var output1 = lruCacheService.LruCache(input1);

            Console.WriteLine($"Example 1: {output1}\n");


            lruCacheService.ReInitializeCache();

            var input2 = new string[] { "A", "B", "A", "C", "A", "B" };

            var output2 = lruCacheService.LruCache(input2);

            Console.WriteLine($"Example 2: {output2}\n");

            
            lruCacheService.ReInitializeCache();

            var input3 = new string[] { "A", "B", "C", "D", "E", "D", "Q", "Z", "C" };

            var output3 = lruCacheService.LruCache(input3);

            Console.WriteLine($"Example 3: {output3}\n");
        }
    }
}
