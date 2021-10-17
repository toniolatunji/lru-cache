using LruCache.Service.Contract;
using LruCache.Service.Implementation;
using Microsoft.Extensions.DependencyInjection;

namespace LruCache.ConsoleApp
{
    public class ServiceRegistration
    {
        public static ServiceProvider GetServiceProvider()
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<ILruCacheService, LruCacheService>()
                .BuildServiceProvider();

            return serviceProvider;
        }
    }
}
