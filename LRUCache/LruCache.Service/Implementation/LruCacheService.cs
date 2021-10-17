using LruCache.Service.Contract;
using System.Collections.Generic;
using System.Linq;

namespace LruCache.Service.Implementation
{
    public class LruCacheService : ILruCacheService
    {
        private Queue<string> Cache;

        private const int QueueSize = 5;

        public string LruCache(string[] input)
        {
            foreach (var item in input)
            {
                var itemToCache = item.ToUpper();

                if (Cache.Count < QueueSize)
                {
                    if (!Cache.Contains(itemToCache))
                    {
                        Cache.Enqueue(itemToCache);
                    }
                    else
                    {
                        Cache = new Queue<string>(Cache.Where(c => c != itemToCache));

                        Cache.Enqueue(itemToCache);
                    }
                }
                else
                {
                    if (!Cache.Contains(itemToCache))
                    {
                        Cache.Dequeue();

                        Cache.Enqueue(itemToCache);
                    }
                    else
                    {
                        Cache = new Queue<string>(Cache.Where(c => c != itemToCache));

                        Cache.Enqueue(itemToCache);
                    }
                }
            }

            return string.Join("-", Cache.Select(c => c));
        }

        public void ReInitializeCache() => Cache = new Queue<string>();
    }
}
